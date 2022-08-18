//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at https://docs.xperience.io/.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.MEDIO;

[assembly: RegisterDocumentType(Contact.CLASS_NAME, typeof(Contact))]

namespace CMS.DocumentEngine.Types.MEDIO
{
	/// <summary>
	/// Represents a content item of type Contact.
	/// </summary>
	public partial class Contact : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "MEDIO.Contact";


		/// <summary>
		/// The instance of the class that provides extended API for working with Contact fields.
		/// </summary>
		private readonly ContactFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// ContactID.
		/// </summary>
		[DatabaseIDField]
		public int ContactID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("ContactID"), 0);
			}
			set
			{
				SetValue("ContactID", value);
			}
		}


		/// <summary>
		/// Name.
		/// </summary>
		[DatabaseField]
		public string Name
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Name"), @"");
			}
			set
			{
				SetValue("Name", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with Contact fields.
		/// </summary>
		[RegisterProperty]
		public ContactFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Contact fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class ContactFields : AbstractHierarchicalObject<ContactFields>
		{
			/// <summary>
			/// The content item of type Contact that is a target of the extended API.
			/// </summary>
			private readonly Contact mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="ContactFields" /> class with the specified content item of type Contact.
			/// </summary>
			/// <param name="instance">The content item of type Contact that is a target of the extended API.</param>
			public ContactFields(Contact instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// ContactID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.ContactID;
				}
				set
				{
					mInstance.ContactID = value;
				}
			}


			/// <summary>
			/// Name.
			/// </summary>
			public string Name
			{
				get
				{
					return mInstance.Name;
				}
				set
				{
					mInstance.Name = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="Contact" /> class.
		/// </summary>
		public Contact() : base(CLASS_NAME)
		{
			mFields = new ContactFields(this);
		}

		#endregion
	}
}