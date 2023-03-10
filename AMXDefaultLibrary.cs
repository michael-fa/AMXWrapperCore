// AMXWrapper for .NET Core
// Copyright 2015-2023 Tim Potze and ported to .NET Core by github.com/michael-fa
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

using System;

namespace AMXWrapperCore
{
    /// <summary>
    ///     Contains all libraries provided by amx32.
    /// </summary>
    [Flags]
    public enum AMXDefaultLibrary
    {
        /// <summary>
        ///     No library.
        /// </summary>
        None,

        /// <summary>
        ///     The console library.
        /// </summary>
        Console,

        /// <summary>
        ///     The core library.
        /// </summary>
        Core,

        /// <summary>
        ///     The d gram library.
        /// </summary>
        DGram,

        /// <summary>
        ///     The string library.
        /// </summary>
        String,

        /// <summary>
        ///     The time library.
        /// </summary>
        Time,

        /// <summary>
        ///     The fixed library.
        /// </summary>
        Fixed,

        /// <summary>
        ///     The float library.
        /// </summary>
        Float,
    }
}