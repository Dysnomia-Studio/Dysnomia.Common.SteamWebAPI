namespace Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList {
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks>Root object for memberlist call on SteamCommunity XML api</remarks>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class memberList {
        /// <remarks>64 bits id of this steam group</remarks>
        public ulong groupID64 { get; set; }

        /// <remarks>Group details</remarks>
        public memberListGroupDetails groupDetails { get; set; }

        /// <remarks>Group member count</remarks>
        public uint memberCount { get; set; }

        /// <remarks>Memberlist page count</remarks>
        public uint totalPages { get; set; }

        /// <remarks>Memberlist current page</remarks>
        public uint currentPage { get; set; }

        /// <remarks>Memberlist starting member counter</remarks>
        public uint startingMember { get; set; }

        /// <remarks>Member list</remarks>
        public string[] members { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class memberListGroupDetails {
        /// <remarks>Group name</remarks>
        public string groupName { get; set; }

        /// <remarks>Group id in URL (can be different from 64 bit id)</remarks>
        public string groupURL { get; set; }

        /// <remarks>Group headline (empty if it's the group containing followers)</remarks>
        public string headline { get; set; }

        /// <remarks>Group summary ("No information given" if it's the group containing followers)</remarks>
        public string summary { get; set; }

        /// <remark>Group small avatar</remark>
        public string avatarIcon { get; set; }

        /// <remark>Group medium avatar</remark>
        public string avatarMedium { get; set; }

        /// <remark>Group large avatar</remark>
        public string avatarFull { get; set; }

        /// <remarks>Group member count</remarks>
        public uint memberCount { get; set; }

        /// <remarks>How many group members are in the chat</remarks>
        public uint membersInChat { get; set; }

        /// <remarks>How many group members are in a game</remarks>
        public uint membersInGame { get; set; }

        /// <remarks>How many group members are online</remarks>
        public uint membersOnline { get; set; }
    }
}
