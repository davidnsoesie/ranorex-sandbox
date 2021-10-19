﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace react_demo
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidateText recording.
    /// </summary>
    [TestModule("0b0bf3b3-4871-4723-9041-0db9d933fc92", ModuleType.Recording, 1)]
    public partial class ValidateText : ITestModule
    {
        /// <summary>
        /// Holds an instance of the react_demoRepository repository.
        /// </summary>
        public static react_demoRepository repo = react_demoRepository.Instance;

        static ValidateText instance = new ValidateText();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateText()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateText Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactAppAnd1MorePageProfile1.Root.InputArea' at 184;23.", repo.ReactAppAnd1MorePageProfile1.Root.InputAreaInfo, new RecordItemIndex(0));
            repo.ReactAppAnd1MorePageProfile1.Root.InputArea.Click("184;23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Validate this text' with focus on 'ReactAppAnd1MorePageProfile1.Root.InputArea'.", repo.ReactAppAnd1MorePageProfile1.Root.InputAreaInfo, new RecordItemIndex(1));
            repo.ReactAppAnd1MorePageProfile1.Root.InputArea.PressKeys("Validate this text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ReactAppAnd1MorePageProfile1.Root.Submit' at 108;13.", repo.ReactAppAnd1MorePageProfile1.Root.SubmitInfo, new RecordItemIndex(2));
            repo.ReactAppAnd1MorePageProfile1.Root.Submit.Click("108;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Validate this text') on item 'ReactAppAnd1MorePageProfile1.Root.ValidateThisText'.", repo.ReactAppAnd1MorePageProfile1.Root.ValidateThisTextInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.ReactAppAnd1MorePageProfile1.Root.ValidateThisTextInfo, "Text", "Validate this text");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
