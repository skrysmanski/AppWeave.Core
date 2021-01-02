﻿#region License
// Copyright 2020 AppMotor Framework (https://github.com/skrysmanski/AppMotor)
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System;

using AppMotor.CliApp.CommandLine;

using JetBrains.Annotations;

namespace AppMotor.CliApp.TestUtils
{
    internal abstract class TestApplicationWithParamsBase : CliApplicationWithParams, ITestApplication
    {
        private readonly TestTerminal _testTerminal = new();

        /// <inheritdoc />
        public string TerminalOutput => this._testTerminal.CurrentOutput;

        /// <inheritdoc />
        public Exception? CaughtException { get; private set; }

        protected TestApplicationWithParamsBase()
        {
            this.Terminal = this._testTerminal;
        }

        [MustUseReturnValue]
        public new int Run(params string[] args)
        {
            this._testTerminal.ResetOutput();
            this.CaughtException = null;
            return base.Run(args);
        }

        /// <inheritdoc />
        protected override void OnUnhandledException(Exception exception, ref int exitCode)
        {
            this.CaughtException = exception;

            base.OnUnhandledException(exception, ref exitCode);
        }
    }
}
