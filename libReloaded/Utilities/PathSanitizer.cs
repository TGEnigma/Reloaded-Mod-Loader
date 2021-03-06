﻿/*
    [Reloaded] Mod Loader Common Library (libReloaded)
    The main library acting as common, shared code between the Reloaded Mod 
    Loader Launcher, Mods as well as plugins.
    Copyright (C) 2018  Sewer. Sz (Sewer56)

    [Reloaded] is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    [Reloaded] is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>
*/

using System.IO;
using System.Linq;

namespace Reloaded.Utilities
{
    /// <summary>
    /// Removes invalid characters from a specified path.
    /// Used for sanitization of controller names and devices which contain symbols
    /// which would form invalid paths.
    /// </summary>
    public static class PathSanitizer
    {
        // Set Invalid Path Characters
        private static readonly char[] Invalid = Path.GetInvalidPathChars().Union(Path.GetInvalidFileNameChars()).ToArray();

        /// <summary>
        /// Removes invalid characters from a specified path.
        /// Used for sanitization of controller names and devices which contain symbols
        /// which would form invalid paths.
        /// </summary>
        /// <returns>Original string without characters deemed invalid in a file path.</returns>
        public static string ForceValidFilePath(string text)
        {
            // Valid path force
            foreach (char c in Invalid)
            {
                // Ignore paths
                if (c != '\\' || c != '/')
                    text = text.Replace(c.ToString(), "");
            }



            return text;
        }
    }
}
