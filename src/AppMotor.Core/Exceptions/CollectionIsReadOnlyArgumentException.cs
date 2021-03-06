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

namespace AppMotor.Core.Exceptions
{
    /// <summary>
    /// <see cref="ArgumentException"/> version of <see cref="CollectionIsReadOnlyException"/>.
    /// </summary>
    public class CollectionIsReadOnlyArgumentException : ArgumentException, ICollectionIsReadOnlyException
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="paramName">The name of the parameter this exception applies to.</param>
        public CollectionIsReadOnlyArgumentException(string paramName)
            : base(CollectionIsReadOnlyException.DEFAULT_MESSAGE, paramName: paramName)
        {
        }
    }
}
