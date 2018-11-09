using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

using TIS.Imaging;

namespace demoapp
{
    public partial class Form1 : Form
    {
        // �ǂꂾ���i�ނ�
        // ��ms�҂�
        // �ǂꂾ���B�邩

        static SerialPort ports;
        private string mDistans; // ��񖈂̑���ړ������i�[�p
        private string numOfImage; // �B�e����
        private static bool directionMoveFlag = true; // radiobutton�p��flag
        private string savePath = "C:\\Users\\Administrator\\Desktop\\test\\";

        // ���x�ݒ�p�ϐ�
        private int initialVelocity = 500;
        private int maxSpeed = 5500;
        private int acceleration = 100;

        // DeNoise�t�B���^ n���̃t���[���𕽋ω�����
        //FrameFilter DeNoiseFilter;
        //DeNoiseFilter = icImagingControl1.FrameFilterCreate("Denoise"", "");

        // �t�B���^���W���[�� *
        private System.Collections.Specialized.StringCollection modulePathCollection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // device�̐ݒ� *
            if (!icImagingControl1.DeviceValid)
            {
                icImagingControl1.ShowDeviceSettingsDialog();
                if (!icImagingControl1.DeviceValid)
                {
                    Close();
                    return;
                }
            }

            // �t�B���^���W���[���ւ̃t���p�X�ۑ��ɃR���N�V�������g�� *
            modulePathCollection = new System.Collections.Specialized.StringCollection();

            // �e�t�B���^���� *
            // - �t�B���^�̃p�X�����łɃ��W���[���p�X�R���N�V�����ɂ��邩�ǂ���
            // - �Ȃ������ꍇ�̓��W���[�������t�B���^���W���[�����X�g�ɒǉ�
            foreach(TIS.Imaging.FrameFilterInfo ffi in icImagingControl1.FrameFilterInfos)
            {
                if(modulePathCollection.IndexOf(ffi.ModulePath) < 0)
                {
                    listBox1.Items.Add(ffi.ModuleName);
                    modulePathCollection.Add(ffi.ModulePath);
                }
            }


            LoadLastUsedDevice();
            UpdateControls();
            StartLiveVideo();
        }

        /// <summary>
        /// exitToolStripMenuItem_Click
        ///
        /// Exit the demo application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// deviceToolStripMenuItem_Click
        ///
        /// Show the device selection dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectDevice();
        }

        /// <summary>
        /// playToolStripMenuItem_Click
        ///
        /// Handler for the play menu item. StartLiveVideo() sub is called.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartLiveVideo();
        }

        /// <summary>
        /// stopToolStripMenuItem_Click
        ///
        /// Stop the live video display by a call to StopLiveVideo() sub.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopLiveVideo();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            icImagingControl1.Size = ClientSize;
        }

        /// <summary>
        /// imageToolStripMenuItem_Click
        ///
        /// Show the video and camera properties dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProperties();
        }

        /// <summary>
        /// writeAviToolStripMenuItem_Click
        ///
        /// Show the AVI capture dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void writeAviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAVIDialog();
        }

        /// <summary>
        /// saveImageToolStripMenuItem_Click
        ///
        /// Handler for the SaveImage menu. SaveImage() Sub is called.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void externalTriggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleTrigger();
        }
        
        /// <summary>
        /// UpdateControls
        ///
        /// UpdateControls enables and disables the menuitems of the application depending of
        /// camera is connected to the computer or not.
        /// </summary>
        private void UpdateControls()
        {
            bool IsDeviceValid = false;

            IsDeviceValid = icImagingControl1.DeviceValid;
            imageToolStripMenuItem.Enabled = IsDeviceValid;
            writeAviToolStripMenuItem.Enabled = IsDeviceValid;
            saveImageToolStripMenuItem.Enabled = IsDeviceValid;
            playToolStripMenuItem.Enabled = IsDeviceValid;
            stopToolStripMenuItem.Enabled = IsDeviceValid;
            ToolbarPlayButton.Enabled = IsDeviceValid;
            ToolBarStopButton.Enabled = IsDeviceValid;

            externalTriggerToolStripMenuItem.Enabled = false;
            ToolBarTriggerButton.Enabled = false;


            if (IsDeviceValid)
            {
                playToolStripMenuItem.Enabled = !icImagingControl1.LiveVideoRunning;
                stopToolStripMenuItem.Enabled = !playToolStripMenuItem.Enabled;
                ToolbarPlayButton.Enabled = !icImagingControl1.LiveVideoRunning;
                ToolBarStopButton.Enabled = !ToolbarPlayButton.Enabled;

                if (icImagingControl1.DeviceTriggerAvailable)
                {
                    externalTriggerToolStripMenuItem.Enabled = true;
                    ToolBarTriggerButton.Enabled = true;
                    externalTriggerToolStripMenuItem.Checked = icImagingControl1.DeviceTrigger;
                    ToolBarTriggerButton.Checked = icImagingControl1.DeviceTrigger;
                }

                if (icImagingControl1.InputChannelAvailable)
                {
                    //Create the sub menus that allow to select the input channels.
                    ToolBarInputChannel.DropDownItems.Clear();
                    inputChannelsToolStripMenuItem.DropDown.Items.Clear();
                    inputChannelsToolStripMenuItem.Enabled = true;
                    ToolBarInputChannel.Enabled = true;

                    foreach (InputChannel s in icImagingControl1.InputChannels)
                    {
                        System.Windows.Forms.ToolStripItem mitem = null;

                        // Add the input channel as menu item to the main menu
                        //mitem = inputChannelsToolStripMenuItem.DropDown.Items.Add(s.ToString());

                        mitem = inputChannelsToolStripMenuItem.DropDownItems.Add(s.ToString());
                    
                        if (icImagingControl1.InputChannel == s.ToString())
                        {
                            ToolStripMenuItem i = (ToolStripMenuItem)mitem;
                            i.Checked = true;
                        }
                        mitem.Click += new System.EventHandler(mnuInputChannelChild_Click);

                        // Add the input channel as menu item to the toolbar button's context menu
                        mitem = ToolBarInputChannel.DropDown.Items.Add(s.ToString());
                        if (icImagingControl1.InputChannel == s.ToString())
                        {
                            ToolStripMenuItem i = (ToolStripMenuItem)mitem;
                            i.Checked = true;
                        }
                        mitem.Click += new System.EventHandler(mnuInputChannelChild_Click);
                    }
                }
                else
                {
                    // Remove the input channels from the submenus.
                    ToolBarInputChannel.DropDownItems.Clear();
                    inputChannelsToolStripMenuItem.DropDown.Items.Clear();
                    inputChannelsToolStripMenuItem.Enabled = false;
                    ToolBarInputChannel.Enabled = false;
                }

            }
            ToolBarSnapButton.Enabled = IsDeviceValid;
            ToolBarAVIButton.Enabled = IsDeviceValid;
            ToolBarPropertiesButton.Enabled = IsDeviceValid;
        }
        
        /// <summary>
        /// toolStrip1_ItemClicked
        ///
        /// Handler for the toolbar play button. StartLiveVideo sub is called.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Evaluate the Button property to determine which button was clicked.
            switch (toolStrip1.Items.IndexOf(e.ClickedItem))
            {
                case 0:
                    StartLiveVideo();
                    break;
                case 1:
                    StopLiveVideo();
                    break;
                case 3:
                    SaveImage();
                    break;
                case 4:
                    ShowAVIDialog();
                    break;
                case 6:
                    SelectDevice();
                    break;
                case 7:
                    ShowProperties();
                    break;
                case 10:
                    ToggleTrigger();
                    break;
            }
        }

        /// <summary>
        /// StartLiveVideo
        ///
        /// Start the live video display and change the button states of the
        /// play and stop button.
        /// </summary>
        private void StartLiveVideo()
        {
            if (icImagingControl1.DeviceValid)
            {
                icImagingControl1.LiveStart();
                playToolStripMenuItem.Enabled = false;
                stopToolStripMenuItem.Enabled = true;
                ToolbarPlayButton.Enabled = false;
                ToolBarStopButton.Enabled = true;
                ToolBarSnapButton.Enabled = true;
            }
        }
        /// <summary>
        /// StopLiveVideo
        ///
        /// Stop the live video display and change the button states of the
        /// play and stop button.
        /// </summary>
        private void StopLiveVideo()
        {
            if (icImagingControl1.DeviceValid)
            {

                icImagingControl1.LiveStop();
                playToolStripMenuItem.Enabled = true;
                stopToolStripMenuItem.Enabled = false;
                ToolbarPlayButton.Enabled = true;
                ToolBarStopButton.Enabled = false;
                ToolBarSnapButton.Enabled = false;
            }
        }

        /// <summary>
        /// SelectDevice
        ///
        /// Show the device selection dialog.
        /// </summary>
        private void SelectDevice()
        {
            if (icImagingControl1.LiveVideoRunning)
            {
                icImagingControl1.LiveStop();
                icImagingControl1.ShowDeviceSettingsDialog();
                if (icImagingControl1.DeviceValid)
                    icImagingControl1.LiveStart();
            }
            else
                icImagingControl1.ShowDeviceSettingsDialog();

            UpdateControls();
            SetWindowSizeToImagesize();

            DeviceSettings.SaveSelectedDevice(icImagingControl1);
            
        }

        /// <summary>
        /// ShowProperties
        ///
        /// Show the property dialog of the current video capture device.
        /// </summary>
        private void ShowProperties()
        {
            if (icImagingControl1.DeviceValid)
            {
                icImagingControl1.ShowPropertyDialog();
                UpdateControls();
            }
        }

        /// <summary>
        /// SaveImage
        ///
        /// Snap (capture) an image from the video stream and save it to harddisk.
        /// </summary>
        private void SaveImage()
        {
            if (icImagingControl1.DeviceValid)
            {
                // Snap (capture) an image to the memory
                icImagingControl1.MemorySnapImage();

                //���b�Z�[�W�{�b�N�X��\������
               // MessageBox.Show("�{�^���e�X�g�B","�e�X�g", MessageBoxButtons.OK, MessageBoxIcon.Question);
                //ConsoleApp(5000);
                // save��ɂ���
                //ConsoleApp(mDistans);
                // Call the save file dialog to enter the file name of the image
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "bmp files (*.bmp)|*.bmp|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Save the image.
                    icImagingControl1.MemorySaveImage(saveFileDialog1.FileName);
                }
            }
        }

        // �������
        private static void ConsoleApp(string m)
        {
            SerialPort port = new SerialPort("COM4", 38400, Parity.None, 8, StopBits.One);

            port.Handshake = Handshake.RequestToSend;
            port.DataReceived += new SerialDataReceivedEventHandler(Read_ReceivedHandler);
            port.Open();
            System.Threading.Thread.Sleep(2000);


            //while (true)
            //{
           
            if(directionMoveFlag == true) { 
                try
                {

                    if (port.IsOpen)
                    {
                        port.Write("Q:" + "\r\n");
                        port.Write("M:1+P" + m + "\r\n");
                        //port.Write("M:1-P5000" + "\r\n");
                        port.Write("G:" + "\r\n");
                        port.Write("Q:" + "\r\n");
                        System.Threading.Thread.Sleep(1000);

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }
            }else
            {
                try
                {

                    if (port.IsOpen)
                    {
                        port.Write("Q:" + "\r\n");
                        port.Write("M:1-P" + m + "\r\n");
                        port.Write("G:" + "\r\n");
                        port.Write("Q:" + "\r\n");
                        System.Threading.Thread.Sleep(1000);

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }
            }
            port.Close();
            port.Dispose();
        }


        private static void Read_ReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort port = (SerialPort)sender;
            byte[] buf = new byte[1024];
            int len = port.Read(buf, 0, 1024);
            string s = Encoding.GetEncoding("UTF-8").GetString(buf, 0, len);
            Console.Write("received message:" + s);
        }

        // �����P�Ɍ��_�ɖ߂閽��
        private static void ReturnToOrigin()
        {
            SerialPort port = new SerialPort("COM4", 38400, Parity.None, 8, StopBits.One);

            port.Handshake = Handshake.RequestToSend;
            port.DataReceived += new SerialDataReceivedEventHandler(Read_ReceivedHandler);
            port.Open();
            System.Threading.Thread.Sleep(2000);

            try
            {

                if (port.IsOpen)
                {
                    port.Write("Q:" + "\r\n");
                    port.Write("H:1" + "\r\n");
                    port.Write("Q:" + "\r\n");
                    System.Threading.Thread.Sleep(1000);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
            }
            
            port.Close();
            port.Dispose();
        }

        // ���x�ݒ�
        private static void speedSetting(int iniSpe, int maxSpe, int acc)
        {
            SerialPort port = new SerialPort("COM4", 38400, Parity.None, 8, StopBits.One);

            port.Handshake = Handshake.RequestToSend;
            port.DataReceived += new SerialDataReceivedEventHandler(Read_ReceivedHandler);
            port.Open();
            System.Threading.Thread.Sleep(2000);

            try
            {

                if (port.IsOpen)
                {
                    port.Write("Q:" + "\r\n");
                    port.Write("D:1S"+ iniSpe + "F"+ maxSpe +"R"+ acc +"\r\n");
                    port.Write("Q:" + "\r\n");
                    System.Threading.Thread.Sleep(1000);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
            }

            port.Close();
            port.Dispose();
        }

        // ���݈ʒu�����_�ɐݒ�
        private static void originSetting()
        {
            SerialPort port = new SerialPort("COM4", 38400, Parity.None, 8, StopBits.One);

            port.Handshake = Handshake.RequestToSend;
            port.DataReceived += new SerialDataReceivedEventHandler(Read_ReceivedHandler);
            port.Open();
            System.Threading.Thread.Sleep(2000);

            try
            {

                if (port.IsOpen)
                {
                    port.Write("Q:" + "\r\n");
                    port.Write("R:1" + "\r\n");
                    port.Write("Q:" + "\r\n");
                    System.Threading.Thread.Sleep(1000);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
            }

            port.Close();
            port.Dispose();
        }

        /// <summary>
        /// ShowAVIDialog
        ///
        /// Show the dialog for AVI capture
        /// </summary>
        private void ShowAVIDialog()
        {
            if (icImagingControl1.DeviceValid)
            {
                AviDialog AVIDlg = new AviDialog(icImagingControl1);
                AVIDlg.ShowDialog();
                AVIDlg.Dispose();
                AVIDlg = null;
            }
        }

        /// <summary>
        /// ToggleTrigger
        ///
        /// Enable or disable the external trigger.
        /// </summary>
        private void ToggleTrigger()
        {
            if (icImagingControl1.DeviceValid)
            {
                if (icImagingControl1.DeviceTriggerAvailable)
                {
                    bool trigger = !icImagingControl1.DeviceTrigger;

                    if (icImagingControl1.LiveVideoRunning)
                    {
                        icImagingControl1.LiveStop();
                        icImagingControl1.DeviceTrigger = trigger;
                        icImagingControl1.LiveStart();
                    }
                    else
                    {
                        icImagingControl1.DeviceTrigger = trigger;
                    }

                    externalTriggerToolStripMenuItem.Checked = trigger;
                    ToolBarTriggerButton.Checked = trigger;
                }
            }
        }

        /// <summary>
        /// SetWindowSizeToImagesize
        ///
        /// Resize the application to the size of the video format.
        /// </summary>
        private void SetWindowSizeToImagesize()
        {
            if (icImagingControl1.DeviceValid)
            {
                // Change the witdth to a minimum size of 230 pixel. If the width is
                // less than 230 pixel, the toolbar can not be seen completely.
                Width = Math.Max(icImagingControl1.ImageWidth + Width - ClientSize.Width, 230);
                Height = icImagingControl1.ImageHeight + Height - ClientSize.Height + toolStrip1.Size.Height;
            }
        }

        /// <summary>
        /// mnuInputChannelChild_Click
        ///
        /// If the video capture device supports input channels, submenus
        /// for the input channel selection are created. This is the handler
        /// sub for the input channel submenus.
        /// The menu text if the clicked submenu item is retrieved and assigned
        /// to the InputChannel property of IC15Control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuInputChannelChild_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.ToolStripMenuItem mitem = null;
            mitem = ((System.Windows.Forms.ToolStripMenuItem)(sender));

            foreach (System.Windows.Forms.ToolStripMenuItem Item in inputChannelsToolStripMenuItem.DropDownItems)
            {
                if (Item.Text == mitem.Text)
                    Item.Checked = true;
                else
                    Item.Checked = false;
            }

            foreach (System.Windows.Forms.ToolStripMenuItem Item in ToolBarInputChannel.DropDown.Items)
            {
                if (Item.Text == mitem.Text)
                    Item.Checked = true;
                else
                    Item.Checked = false;
            }
             

            icImagingControl1.InputChannel = mitem.Text;
            // Save the new input channel to the registry.
            DeviceSettings.SaveSelectedDevice(icImagingControl1);
           
        }

        /// <summary>
        /// LoadLastUsedDevice
        ///
        /// Retrieve the last used video capture device from the registry and
        /// open it. The implementation of these functionallity is in the
        /// modul devicesettings.vb
        /// </summary>
        private void LoadLastUsedDevice()
        {
            DeviceSettings.OpenSelectedDevice(icImagingControl1);
            SetWindowSizeToImagesize();
        }

        // �B�e�J�n
        private void imageTaking()
        {
            // ����X�s�[�h��ݒ�l�ɏ�����
            speedSetting(initialVelocity, maxSpeed, acceleration);

            // �ǂݍ���ŉ摜��buffer�Ɏ擾 denoize�̂��� n��B�e���Ă���̕��ς��Ƃ��ĕۑ�
            // -> filter������Ă��ꂽ
            // �摜��ۑ����������𓮍�

            // �摜�ۑ��_�C�A���O��\��
            SaveFileDialog saveFileDialog1;
            

            // �B�e�Ԋu���摜����������
            for (int i = 0; i < int.Parse(numOfImage); i++)
            {
                // ��������X���[�v
                System.Threading.Thread.Sleep(1000);

                // ���ݕ\������Ă���摜���摜�o�b�t�@�ɕۑ�
                icImagingControl1.MemorySnapImage();
                //saveFileDialog1 = new SaveFileDialog();
                //saveFileDialog1.Filter = "bmp files (*.bmp)|*.bmp|All files (*.*)|*.*";
                //saveFileDialog1.FilterIndex = 1;
                //saveFileDialog1.RestoreDirectory = true;


                // ��������X���[�v
                System.Threading.Thread.Sleep(1000);

                // �L���v�`���摜��ۑ�
                //icImagingControl1.MemorySaveImage(saveFileDialog1.FileName + i + ".bmp");
                icImagingControl1.MemorySaveImage(savePath + i + ".bmp");

                // ��������X���[�v
                System.Threading.Thread.Sleep(2000);

                // �������
                ConsoleApp(mDistans);
            }

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            mDistans = toolStripTextBox1.Text;
            MessageBox.Show(mDistans, "�B�e�Ԋu", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        // ���_���A�p(��)
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ReturnToOrigin();
            MessageBox.Show("���_���A���܂����B", "�e�X�g", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        // �J�n�{�^��
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            imageTaking();
        }

        // ���݈ʒu�����_��
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            originSetting();
        }

        // �B�e��������{�^��
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            numOfImage = toolStripTextBox2.Text;
            MessageBox.Show(numOfImage, "�B�e�摜����", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        // radiobutton���`�F�b�N���ꂽ���̓���
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            directionMoveFlag = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            directionMoveFlag = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ModulePaths�R���N�V�������I�����ꂽ���W���[���̃t���p�X���擾 *
            string selectedModulePath = modulePathCollection[listBox1.SelectedIndex];

            listBox2.Items.Clear();
            foreach (FrameFilterInfo ffi in icImagingControl1.FrameFilterInfos) 
            {
                if(ffi.ModulePath == selectedModulePath)
                {
                    listBox2.Items.Add(ffi);
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // �I�����ꂽFrameFilterInfo�I�u�W�F�N�g�̎擾 *
            FrameFilterInfo ffi = (FrameFilterInfo)listBox2.SelectedItem;

            if(ffi != null)
            {
                // �V����FrameFilter�C���X�^���X�̍쐬
                FrameFilter newFrameFilter = icImagingControl1.FrameFilterCreate(ffi);

                // ���C�u���[�h�ł���ꍇ�͒�~
                bool wasLive = icImagingControl1.LiveVideoRunning;
                if (wasLive)
                {
                    icImagingControl1.LiveStop();
                }

                // �V�����t���[���t�B���^���Z�b�g����
                icImagingControl1.DeviceFrameFilters.Clear();
                icImagingControl1.DeviceFrameFilters.Add(newFrameFilter);

                // ���C�u���[�h���A�N�e�B�u�̏ꍇ�ăX�^�[�g
                if (wasLive)
                {
                    icImagingControl1.LiveStart();
                }
                label3.Text = newFrameFilter.Name;
                button1.Enabled = newFrameFilter.HasDialog;
                button2.Enabled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // Dialog *
        private void button1_Click(object sender, EventArgs e)
        {
            icImagingControl1.DeviceFrameFilters[0].ShowDialog();
        }

        // Remove *
        private void button2_Click(object sender, EventArgs e)
        {
            // �������C�u���[�h���������~
            bool wasLive = icImagingControl1.LiveVideoRunning;
            if (wasLive)
            {
                icImagingControl1.LiveStop();
            }

            // �f�o�C�X�I��Dialog��\��
            icImagingControl1.DeviceFrameFilters.Clear();

            // ���C�u���[�h���A�N�e�B�u�̏ꍇ���X�^�[�g
            if (wasLive)
            {
                icImagingControl1.LiveStart();
            }

            label3.Text = "<no filter>";
            button1.Enabled = false;
            button2.Enabled = false;
            listBox2.SelectedItem = null;

        }

        private void speedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void ToolbarPlayButton_Click(object sender, EventArgs e)
        {

        }
    }
}