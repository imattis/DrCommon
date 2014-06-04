﻿/*
  IDrData.cs -- Interface for intermodule interaction using DrData abstraction layer 1.0.1, May 17, 2014
 
  Copyright (c) 2013-2014 Kudryashov Andrey aka Dr
 
  This software is provided 'as-is', without any express or implied
  warranty. In no event will the authors be held liable for any damages
  arising from the use of this software.

  Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

      1. The origin of this software must not be misrepresented; you must not
      claim that you wrote the original software. If you use this software
      in a product, an acknowledgment in the product documentation would be
      appreciated but is not required.

      2. Altered source versions must be plainly marked as such, and must not be
      misrepresented as being the original software.

      3. This notice may not be removed or altered from any source distribution.

      Kudryashov Andrey <kudryashov.andrey at gmail.com>

 */

namespace DrOpen.DrCommon.DrData
{
    public interface IDrData
    {
        /// <summary>
        /// Executes the specified function as node name with the specified arguments in child nodes.
        /// </summary>
        /// <param name="value">node contains the function name and arguments to execute</param>
        /// <returns></returns>
        DDNode Do(DDNode value);
        /// <summary>
        /// Reserved. Should be retrun null.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        DDNode Get(DDNode value);
        /// <summary>
        /// Reserved. Should be retrun null.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        DDNode Set(DDNode value);
        /// <summary>
        /// Reserved. Should be retrun null.
        /// </summary>
        /// <returns></returns>
        DDNode GetSchema();
    }
}
