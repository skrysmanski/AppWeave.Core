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

using AppMotor.Core.Utils;

using JetBrains.Annotations;

namespace AppMotor.Core.Exceptions
{
    /// <summary>
    /// Equivalent to <see cref="ArgumentException"/> - just for values that are not arguments/parameters.
    /// </summary>
    [PublicAPI]
    public class ValueException : Exception
    {
        /// <summary>
        /// The name of the value this exception applies to.
        /// </summary>
        public string? ValueName { get; }

        // NOTE: This implementation mirrors how "ArgumentException" incorporates the parameter name into its message
        //   (i.e. by overriding the "Message" property instead of doing this in the constructor).
        /// <inheritdoc />
        public override string Message
        {
            get
            {
                var message = base.Message;

                if (string.IsNullOrEmpty(this.ValueName))
                {
                    return message;
                }

                return message + " (Value name: '" + this.ValueName + "')";
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        [PublicAPI]
        public ValueException()
            : this(message: null, valueName: null, innerException: null)
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        [PublicAPI]
        public ValueException(string? message)
            : this(message: message, valueName: null, innerException: null)
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="valueName">The name of the value this exception applies to.</param>
        [PublicAPI]
        public ValueException(string? message, string? valueName)
            : this(message: message, valueName: valueName, innerException: null)
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The inner exception</param>
        [PublicAPI]
        public ValueException(string? message, Exception? innerException)
            : this(message: message, valueName: null, innerException: innerException)
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="valueName">The name of the value this exception applies to.</param>
        /// <param name="innerException">The inner exception</param>
        [PublicAPI]
        public ValueException(string? message, string? valueName, Exception? innerException)
            : base(message ?? Validate.ExceptionMessages.DEFAULT_MESSAGE, innerException)
        {
            this.ValueName = valueName;
        }
    }
}
