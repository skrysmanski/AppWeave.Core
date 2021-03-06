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

namespace AppMotor.Core.Utils
{
    /// <summary>
    /// Provides a method to convert an arbitrary value into a string.
    /// </summary>
    /// <remarks>
    /// This interface is basically a simplified version of <see cref="ICustomFormatter"/>.
    /// </remarks>
    public interface IValueFormatter
    {
        /// <summary>
        /// Converts the specified value into a string. The exact format of the
        /// return value is up to the implementation.
        ///
        /// <para>It's up to the implementation what to return if <paramref name="value"/>
        /// is <c>null</c>. Both <c>null</c> and empty string are allowed.</para>
        /// </summary>
        /// <remarks>
        /// This method is generic so that boxing can be avoid for value types.
        /// </remarks>
        string? FormatValue<T>(T value);
    }
}
