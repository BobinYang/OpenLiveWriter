// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for details.

using System.ComponentModel;
using OpenLiveWriter.Controls;

namespace OpenLiveWriter.PostEditor.Configuration.Wizard.DisplayMessages
{

    public class ErrorConnectingDisplayMessage : DisplayMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Container components = null;

        public ErrorConnectingDisplayMessage(IContainer container)
        {
            ///
            /// Required for Windows.Forms Class Composition Designer support
            ///
            container.Add(this);
            InitializeComponent();

        }

        public ErrorConnectingDisplayMessage()
        {
            ///
            /// Required for Windows.Forms Class Composition Designer support
            ///
            InitializeComponent();

        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if(components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            //
            // UsernameAndPasswordRequiredDisplayMessage
            //
            this.Text = "An error occurred while attempting to connect to the remote server.";
            this.Title = "Error Connecting";
            this.Type = DisplayMessageType.Warning;

        }
        #endregion
    }
}