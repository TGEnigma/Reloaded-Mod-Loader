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

using System;
using System.IO;
using SystemProcess = System.Diagnostics.Process;

namespace Reloaded.Process
{
    /// <summary>
    /// The ReloadedProcess class provides various ways by which a game process may be manipulated,
    /// inclusive of suspending, resuming threads, and writing/reading memory.
    /// Note: Most of the implementation for ReloadedProcess is included in the other classes within this source directory.
    /// This class is only for creating the object and storing the properties.
    /// </summary>
    public class ReloadedProcess
    {
        /// <summary>
        /// Stores an instance of System.Diagnostics.Process inside ReloadedProcess.
        /// </summary>
        public SystemProcess Process { get; private set; }

        /// <summary>
        /// A handle to the program's first thread itself. 
        /// The handle is used to specify the process in all functions that perform operations on the Windows' Internal thread object.
        /// </summary>
        public IntPtr ThreadHandle { get; private set; }

        /// <summary>
        /// An individual ID value that can be used to identify the program's first thread. 
        /// </summary>
        public IntPtr ThreadId { get; private  set; }

        /// <summary>
        /// An individual ID value that can be used to identify a process (as seen in Task Manager). 
        /// </summary>
        public IntPtr ProcessId { get; private set; }

        /// <summary>
        /// A handle to the process itself. 
        /// The handle is used to specify the process in all functions that perform operations on the Windows' Internal process object.
        /// </summary>
        public IntPtr ProcessHandle { get; private set; }

        /// <summary>
        /// Empty constructor.
        /// </summary>
        public ReloadedProcess() { }

        /// <summary>
        /// Creates a process in a suspended state for us to use.
        /// In order to start the application's execution, consider running SuspendThread(threadHandle).
        /// Note: The process starts suspended by default, you should call ResumeFirstThread() via 
        /// <see cref="ReloadedExtensions"/> or ResumeAllThreads().
        /// </summary>
        /// <param name="filePath">
        ///     The file path to the executable to launch.
        ///     The file path should NOT be wrapped in quotes.
        /// </param>
        /// <param name="arguments">
        ///     The command line arguments to be passed.
        ///     Each individual command line argument should be wrapped in quotes in case of spaces.
        /// </param>
        public ReloadedProcess(string filePath, string[] arguments)
        {
            // Build up the arguments string.
            string lpCommandLine = filePath;

            // Build arguments if necessary.
            if (arguments != null)
            {
                lpCommandLine += " ";

                // Append all arguments.
                foreach (string argument in arguments)
                { lpCommandLine += argument + " "; }

                // Trim last whitespace
                lpCommandLine = lpCommandLine.Substring(0, lpCommandLine.Length - 1);
            }

            // Start up the process
            Native.Native.STARTUPINFO startupInfo = new Native.Native.STARTUPINFO();
            bool success =  Native.Native.CreateProcess(null, lpCommandLine, IntPtr.Zero, 
                            IntPtr.Zero, false, Native.Native.ProcessCreationFlags.CREATE_SUSPENDED,
                            IntPtr.Zero, Path.GetDirectoryName(filePath), ref startupInfo, 
                            out Native.Native.PROCESS_INFORMATION processInformation);

            // Move Process Properties.
            ProcessHandle = processInformation.hProcess;
            ThreadHandle = processInformation.hThread;
            ProcessId = (IntPtr) processInformation.dwProcessId;
            ThreadId = (IntPtr)  processInformation.dwThreadId;

            // Print Error is Failed
            if (!success) { Bindings.PrintError?.Invoke($"Failed to start ReloadedProcess {filePath}. Is your path correct?"); }
        }

        /// <summary>
        /// Creates a process in a suspended state for us to use.
        /// In order to start the application's execution, consider running SuspendThread(threadHandle).
        /// </summary>
        /// <param name="filePath">
        ///     The file path to the executable to launch.
        ///     The file path should NOT be wrapped in quotes.
        /// </param>
        public ReloadedProcess(string filePath) : this(filePath, null)
        { }

        /// <summary>
        /// Creates an instance of ReloadedProcess from a supplied process
        /// </summary>
        /// <param name="processId">The process ID (PID) to create the Reloaded Process from.</param>
        public ReloadedProcess( SystemProcess process ) : this()
        {
            Process = process;

            // Set Process ID
            ProcessId = ( IntPtr )process.Id;

            // Get Process Handle
            ProcessHandle = Native.Native.OpenProcess( Native.Native.PROCESS_ALL_ACCESS, false, ( int )ProcessId );

            // Set thread id and handle to be that of first thread.
            ThreadId = ( IntPtr )process.Threads[0].Id;

            // Set thread handle to be that of the first thread.
            ThreadHandle = Native.Native.OpenThread( Native.Native.THREAD_ALL_ACCESS, false, ( int )ThreadId );
        }

        /// <summary>
        /// Creates an instance of ReloadedProcess from a supplied process ID.
        /// </summary>
        /// <param name="processId">The process ID (PID) to create the Reloaded Process from.</param>
        public ReloadedProcess(uint processId)
        {
            // Set Process ID
            ProcessId = (IntPtr)processId;

            // Get Process Handle
            ProcessHandle = Native.Native.OpenProcess(Native.Native.PROCESS_ALL_ACCESS, false, (int)ProcessId);

            // Get C# Process by ID
            var process = SystemProcess.GetProcessById((int)processId);

            // Set thread id and handle to be that of first thread.
            ThreadId = (IntPtr)process.Threads[0].Id;

            // Set thread handle to be that of the first thread.
            ThreadHandle = Native.Native.OpenThread(Native.Native.THREAD_ALL_ACCESS, false, (int)ThreadId);
        }


        /// <summary>
        /// Creates an instance of ReloadedProcess from a supplied process name.
        /// </summary>
        /// <param name="processName">The process name to find obtain Reloaded process from.</param>
        public static ReloadedProcess GetProcessByName(string processName)
        {
            try
            {
                // Create new ReloadedProcess
                ReloadedProcess reloadedProcess = new ReloadedProcess();

                // Get Process by Name
                var process = SystemProcess.GetProcessesByName(processName)[0];

                // Set Process ID
                reloadedProcess.ProcessId = (IntPtr)process.Id;

                // Get Process Handle
                reloadedProcess.ProcessHandle = Native.Native.OpenProcess(Native.Native.PROCESS_ALL_ACCESS, false, (int)reloadedProcess.ProcessId);

                // Set thread id and handle to be that of first thread.
                reloadedProcess.ThreadId = (IntPtr)process.Threads[0].Id;

                // Set thread handle to be that of the first thread.
                reloadedProcess.ThreadHandle = Native.Native.OpenThread(Native.Native.THREAD_ALL_ACCESS, false, (int)reloadedProcess.ThreadId);

                // Retrun Reloaded Process
                return reloadedProcess;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Returns an instance of ReloadedProcess from the current Process.
        /// </summary>
        /// <returns></returns>
        public static ReloadedProcess GetCurrentProcess()
        {
            // Get Current Process
            var currentProcess = SystemProcess.GetCurrentProcess();

            // Return Reloaded Process
            return new ReloadedProcess(currentProcess);
        }

        /// <summary>
        /// Retrieves Process from the current ReloadedProcess.
        /// </summary>
        /// <returns>Process class for the current Reloaded Process.</returns>
        public SystemProcess GetProcessFromReloadedProcess()
        {
            if (Process != null)
                return Process;

            Process = SystemProcess.GetProcessById((int)ProcessId);
            return Process;
        }
    }
}
