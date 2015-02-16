//
// Class	:	SALSalesLineBatchPrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	2/16/2015 7:27:49 PM
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;

namespace POS.DataLayer
{
	public class SALSalesLineBatchPrimaryKey
	{

	#region Class Level Variables
			private int?           	_salesLineBatchIDNonDefault	= null;
	#endregion

	#region Constants

	#endregion

	#region Constructors / Destructors

		/// <summary>
		/// Constructor setting values for all fields
		/// </summary>
		public SALSalesLineBatchPrimaryKey(int? salesLineBatchID) 
		{
	
			
			this._salesLineBatchIDNonDefault = salesLineBatchID;

		}

		#endregion

	#region Properties

		/// <summary>
		/// This property is mapped to the "SalesLineBatchID" field.  Mandatory.
		/// </summary>
		public int? SalesLineBatchID
		{
			get 
			{ 
				return _salesLineBatchIDNonDefault;
			}
			set 
			{
			
				_salesLineBatchIDNonDefault = value; 
			}
		}

		#endregion

	#region Methods (Public)

		/// <summary>
		/// Method to get the list of fields and their values
		/// </summary>
		///
		/// <returns>Name value collection containing the fields and the values</returns>
		///
		/// <remarks>
		///
		/// <RevisionHistory>
		/// Author				Date			Description
		/// DLGenerator			2/16/2015 7:27:49 PM				Created function
		/// 
		/// </RevisionHistory>
		///
		/// </remarks>
		///
		public NameValueCollection GetKeysAndValues() 
		{
			NameValueCollection nvc=new NameValueCollection();
			
			nvc.Add("SalesLineBatchID",_salesLineBatchIDNonDefault.ToString());
			return nvc;
			
		}

		#endregion	
		
	#region Methods (Private)

	#endregion

	}
}
