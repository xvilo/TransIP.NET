﻿using System.Runtime.Serialization;

namespace TransIp.Api.Dto
{
	/// <summary>
	/// This class models a Domain
	/// </summary>
	[DataContract]
	public class Domain
	{
		/// <summary>
		/// The name, including the tld of this domain
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; }

		/// <summary>
		/// The list of nameservers (with optional gluerecords) for this domain
		/// </summary>
		[DataMember(Name = "nameservers")]
		public Nameserver[] Nameservers { get; set; }

		/// <summary>
		/// The list of WhoisContacts for this domain
		/// </summary>
		[DataMember(Name = "contacts")]
		public WhoisContact[] Contacts { get; set; }

		/// <summary>
		/// The list of DnsEntries for this domain
		/// </summary>
		[DataMember(Name = "dnsEntries")]
		public DnsEntry[] DnsEntries { get; set; }

		/// <summary>
		/// The branding for this domain, some Tlds support additional
		/// whois- and transfer-branding which will be stored in this variable.
		/// Even if a Tld does not support  branding, it will
		/// always be stored in this variable for consistency.
		/// </summary>
		[DataMember(Name = "branding")]
		public DomainBranding Branding { get; set; }

		/// <summary>
		/// The authcode for this domain as generated by the registry. Read-only.
		/// </summary>
		[DataMember(Name = "authCode")]
		public string AuthCode { get; protected set; }

		/// <summary>
		/// If this domain supports locking, this flag is true when the domain is locked
		/// at the registry, false if not. Read-only.
		/// 
		/// Use DomainService.SetLock() to change the lock status of a domain.
		/// </summary>
		[DataMember(Name = "isLocked")]
		public bool? IsLocked { get; protected set; }

		/// <summary>
		/// Registration date of the domain. Read-only.
		/// </summary>
		[DataMember(Name = "registrationDate")]
		public string RegistrationDate { get; protected set; }

		/// <summary>
		/// Next renewal date of the domain. Read-only.
		/// </summary>
		[DataMember(Name = "renewalDate")]
		public string RenewalDate { get; protected set; }

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Domain()
		{
			Nameservers = new Nameserver[0];
			Contacts = new WhoisContact[0];
			DnsEntries = new DnsEntry[0];
		}
	}
}