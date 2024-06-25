using System.Threading.Tasks;
using SageOneApi.Models;

namespace SageOneApi.Interfaces
{
	public interface ISupplierReturnRequest
	{
		/// <summary>
		/// Gets a single supplier return by ID.
		/// </summary>
		/// <param name="id">The ID of the return.</param>
		/// <returns>A <see cref="SupplierReturn"/> object</returns>
		/// 
		SupplierReturn Get(int id);

		/// <summary>
		/// Gets a collection of supplier returns.
		/// </summary>
		/// <param name="includeDetail">if set to <c>true</c> include the lines.</param>
		/// <param name="includeSupplierDetails">if set to <c>true</c> the Supplier is included.</param>
		/// <param name="filter">Optional OData Filter Query read more at http://www.odata.org/documentation/odata-version-2-0/uri-conventions/#FilterSystemQueryOption </param>
		/// <param name="skip">OData skip parameter. Skips the number of records. Used for paging.</param>
		/// <returns></returns>
		PagingResponse<SupplierReturn> Get(bool includeDetail = false, bool includeSupplierDetails = false, string filter = "", int skip = 0);

		/// <summary>
		/// Saves the specified supplier return.
		/// </summary>
		/// <param name="return">The supplier return.</param>
		/// <returns>A <see cref="SupplierReturn"/> object, populated with updated/new values</returns>
		SupplierReturn Save(SupplierReturn @return);

		/// <summary>
		/// Saves the specified supplier asynchronously.
		/// </summary>
		/// <param name="return">The supplier return.</param>
		/// <returns>A <see cref="SupplierReturn"/> object, populated with updated/new values</returns>
		Task<SupplierReturn> SaveAsync(SupplierReturn @return);


		/// <summary>
		/// Calculates the specified supplier return total fields
		/// </summary>
		/// <param name="return">The supplier return.</param>
		/// <returns>A <see cref="SupplierReturn"/> object, populated with updated total fields.</returns>
		SupplierReturn Calculate(SupplierReturn @return);

		/// <summary>
		/// Emails the specified Supplier return.
		/// </summary>
		/// <param name="email">The email request.</param>
		/// <returns>True if successfully sent, otherwise false</returns>
		bool Email(EmailRequest email);
	}
}