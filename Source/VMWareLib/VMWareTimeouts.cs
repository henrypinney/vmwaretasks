using System;
using System.Collections.Generic;
using System.Text;

namespace Vestris.VMWareLib
{
    public class VMWareTimeouts
    {
        public int ConnectTimeout;
        public int OpenFileTimeout;
        public int RevertToSnapshotTimeout;
        public int RemoveSnapshotTimeout;
        public int CreateSnapshotTimeout;
        /// <summary>
        /// the operational time to bring the power to/from the vm, not to boot it
        /// </summary>
        public int PowerOnTimeout;
        public int PowerOffTimeout;
        public int WaitForToolsInGuestTimeout;
        /// <summary>
        /// the time to actually boot the machine
        /// </summary>
        public int LoginTimeout;
        /// <summary>
        /// copy is very slow, see http://communities.vmware.com/thread/184489
        /// </summary>
        public int CopyFileTimeout;
        public int DeleteTimeout;
        public int RunProgramInGuestTimeout;
        public int FileExistsTimeout;
        public int LogoutTimeout;
        public int ListDirectoryInGuestTimeout;
        public int ReadVariableTimeout;
        public int WriteVariableTimeout;
        public int GetSharedFoldersTimeout;
        public int AddRemoveSharedFolderTimeout;
        public int CaptureScreenImageTimeout;

        public VMWareTimeouts()
            : this(60)
        {
        }

        public VMWareTimeouts(int baseTimeout)
        {
            ConnectTimeout = baseTimeout;
            OpenFileTimeout = baseTimeout;
            RevertToSnapshotTimeout = baseTimeout;
            RemoveSnapshotTimeout = baseTimeout * 10;
            CreateSnapshotTimeout = baseTimeout * 10;
            PowerOnTimeout = baseTimeout;
            PowerOffTimeout = baseTimeout;
            WaitForToolsInGuestTimeout = 5 * baseTimeout;
            LoginTimeout = baseTimeout;
            CopyFileTimeout = 20 * baseTimeout;
            DeleteTimeout = baseTimeout;
            RunProgramInGuestTimeout = 5 * baseTimeout;
            FileExistsTimeout = baseTimeout;
            LogoutTimeout = baseTimeout;
            ListDirectoryInGuestTimeout = baseTimeout;
            ReadVariableTimeout = baseTimeout;
            WriteVariableTimeout = baseTimeout;
            GetSharedFoldersTimeout = baseTimeout;
            AddRemoveSharedFolderTimeout = baseTimeout;
            CaptureScreenImageTimeout = baseTimeout;
        }
    }
}