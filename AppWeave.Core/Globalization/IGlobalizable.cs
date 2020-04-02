﻿#region License
// Copyright 2020 - 2020 AppWeave.Core (https://github.com/skrysmanski/AppWeave.Core)
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

using System.Globalization;

using JetBrains.Annotations;

namespace AppWeave.Core.Globalization
{
    /// <summary>
    /// Provides a method to convert values into strings by using
    /// <see cref="CultureInfo"/> as reference.
    /// </summary>
    public interface IGlobalizable
    {
        /// <summary>
        /// Converts the value of this instance to an equivalent string using
        /// the specified culture-specific formatting information.
        /// </summary>
        [PublicAPI, NotNull]
        string ToString([CanBeNull] CultureInfo culture);
    }
}