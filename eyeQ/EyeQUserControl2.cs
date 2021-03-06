﻿/*------------------- COPYRIGHT AND TRADEMARK INFORMATION -------------------+
  |                                                                          |
  |    Mirartech Ltd Software, Source Code and Object Code                   |
  |                                                                          |
  |    (c) 2012 Mirartech Ltd. All rights reserved.                          |
  |                                                                          |
  |    Mirartech, the Mirartech logo and EyeQ are trademarks and/or          |
  |    registered trademarks of Mirartech Ltd or its affiliates in the       |             |
  |    United Kingdom and/or other countries.                                |
  |    All code in this project is owned and copyrighted (2012)              |
  |    by Mirartech Ltd.                                                     |
  |                                                                          |
  +---------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections;
using System.Threading;
using Goldeni;

namespace eyeQ
{
    public partial class EyeQUserControl2 : UserControl
    {
        private int parentWindowHandle; //Handle of Top Level Window
        private bool firstUse = true;

        public EyeQUserControl2()
        {
            InitializeComponent();
        }

        public void InitializeServices(int parentWindowHandle)
        {
            // Debug
            Console.WriteLine("Connecting to services...\n");

            //Store the parent handle for later use
            this.parentWindowHandle = parentWindowHandle;

            //Now register to use Golden-i Services
            ServiceManager.OnServiceManagerEvent += new ServiceManagerEventHandler(ServiceManager_OnServiceManagerEvent);
            try
            {
                ServiceManager.Initialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to initialize Golden-i Services\r\n" + ex.Message);
                return;
            }

            //Register to receive headtracker events
            ServiceManager.HeadtrackerRegister(parentWindowHandle);

            //Use the invoke method to press the Start Button from the UI thread -this will 
            //cause the 'Start' button command to be registered with the ASR
            // TODO
            //this.Invoke(new EventHandler(cancelBtn_Click));

        }

        ////////////////////////////////////////////////////////
        //
        // Close Services
        // Close down nicely. This is called from the main frame
        // when the Close event is fired there
        //
        ////////////////////////////////////////////////////////
        public void CloseServices()
        {
            ServiceManager.Closedown();
        }

        ////////////////////////////////////////////////////////
        //
        // Listen to Incoming Messages from Service Manager
        //
        ////////////////////////////////////////////////////////
        void ServiceManager_OnServiceManagerEvent(IPCMessage ipcMessage)
        {
            // Debug
            //Console.WriteLine("ServiceManager_OnServiceManagerEvent...\r\n");

            //What type of message - ASR or Headtracker

            if (ipcMessage.MessageType == MessageType.ASR)
            {
                if (ipcMessage.MessageSubType == MessageSubType.Asr_GrammarRecognized)
                {
                    //Last ASR Message
                    this.Invoke(new EventHandler(ASRCommandSpoken), new object[] { ipcMessage.PayloadAsString });
                }
            }

            //Head-tracker Events?
            if (ipcMessage.MessageType == MessageType.Headtracker)
            {
                if (ipcMessage.MessageSubType == MessageSubType.Headtracker_Moved)
                {
                    //Movement is deltaX and deltaY, stored in user1 and user2 parameters of message
                    int deltaX = ipcMessage.User1;
                    int deltaY = ipcMessage.User2;
                }
            }

        }

        ////////////////////////////////////////////////////////
        //
        // ASR Command Spoken - A Thread Safe Handler for incoming
        // spoken commands
        // This method runs within the UI thread so its now safe
        // to reference and change onscreen controls
        //
        ////////////////////////////////////////////////////////
        void ASRCommandSpoken(object spokenCommandObject, EventArgs e)
        {
            // Debug
            //Console.WriteLine("ASRCommandSpoken method called.");

            //Extract the spoken command, passed as an Object
            String spokenCommand = "";
            if (spokenCommandObject != null) spokenCommand = spokenCommandObject.ToString();

            // Debug
            //Console.WriteLine("SpokenCommand is... " + spokenCommand);

            //We spoke a command. Which one?
            if (spokenCommand.Equals(deliverMessageBtn.Text))
            {
                Console.WriteLine("showManualsBtn called.");
                //Call the click method as if we'd actually clicked on the button
                //showManualsBtn_Click(null, null);
            }
        }

        private void messageGoBackBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
