// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Azure;
    using Management;
    using Compute;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes an Operating System disk.
    /// </summary>
    public partial class OSDisk
    {
        /// <summary>
        /// Initializes a new instance of the OSDisk class.
        /// </summary>
        public OSDisk() { }

        /// <summary>
        /// Initializes a new instance of the OSDisk class.
        /// </summary>
        /// <param name="createOption">The create option. Possible values
        /// include: 'fromImage', 'empty', 'attach'</param>
        /// <param name="osType">The Operating System type. Possible values
        /// include: 'Windows', 'Linux'</param>
        /// <param name="encryptionSettings">The disk encryption
        /// settings.</param>
        /// <param name="name">The disk name.</param>
        /// <param name="vhd">The virtual hard disk.</param>
        /// <param name="image">The source user image virtual hard disk. The
        /// virtual hard disk will be copied before using it to attach to the
        /// virtual machine. If SourceImage is provided, the destination
        /// virtual hard disk must not exist.</param>
        /// <param name="caching">The caching type. Possible values include:
        /// 'None', 'ReadOnly', 'ReadWrite'</param>
        /// <param name="diskSizeGB">The initial disk size, in GB, for blank
        /// data disks, and the new desired size for resizing existing OS and
        /// data disks.</param>
        /// <param name="managedDisk">The managed disk parameters.</param>
        public OSDisk(DiskCreateOptionTypes createOption, OperatingSystemTypes? osType = default(OperatingSystemTypes?), DiskEncryptionSettings encryptionSettings = default(DiskEncryptionSettings), string name = default(string), VirtualHardDisk vhd = default(VirtualHardDisk), VirtualHardDisk image = default(VirtualHardDisk), CachingTypes? caching = default(CachingTypes?), int? diskSizeGB = default(int?), ManagedDiskParameters managedDisk = default(ManagedDiskParameters))
        {
            OsType = osType;
            EncryptionSettings = encryptionSettings;
            Name = name;
            Vhd = vhd;
            Image = image;
            Caching = caching;
            CreateOption = createOption;
            DiskSizeGB = diskSizeGB;
            ManagedDisk = managedDisk;
        }

        /// <summary>
        /// Gets or sets the Operating System type. Possible values include:
        /// 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public OperatingSystemTypes? OsType { get; set; }

        /// <summary>
        /// Gets or sets the disk encryption settings.
        /// </summary>
        [JsonProperty(PropertyName = "encryptionSettings")]
        public DiskEncryptionSettings EncryptionSettings { get; set; }

        /// <summary>
        /// Gets or sets the disk name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the virtual hard disk.
        /// </summary>
        [JsonProperty(PropertyName = "vhd")]
        public VirtualHardDisk Vhd { get; set; }

        /// <summary>
        /// Gets or sets the source user image virtual hard disk. The virtual
        /// hard disk will be copied before using it to attach to the virtual
        /// machine. If SourceImage is provided, the destination virtual hard
        /// disk must not exist.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public VirtualHardDisk Image { get; set; }

        /// <summary>
        /// Gets or sets the caching type. Possible values include: 'None',
        /// 'ReadOnly', 'ReadWrite'
        /// </summary>
        [JsonProperty(PropertyName = "caching")]
        public CachingTypes? Caching { get; set; }

        /// <summary>
        /// Gets or sets the create option. Possible values include:
        /// 'fromImage', 'empty', 'attach'
        /// </summary>
        [JsonProperty(PropertyName = "createOption")]
        public DiskCreateOptionTypes CreateOption { get; set; }

        /// <summary>
        /// Gets or sets the initial disk size, in GB, for blank data disks,
        /// and the new desired size for resizing existing OS and data disks.
        /// </summary>
        [JsonProperty(PropertyName = "diskSizeGB")]
        public int? DiskSizeGB { get; set; }

        /// <summary>
        /// Gets or sets the managed disk parameters.
        /// </summary>
        [JsonProperty(PropertyName = "managedDisk")]
        public ManagedDiskParameters ManagedDisk { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EncryptionSettings != null)
            {
                EncryptionSettings.Validate();
            }
        }
    }
}

