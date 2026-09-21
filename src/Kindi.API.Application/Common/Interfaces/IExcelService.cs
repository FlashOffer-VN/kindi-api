using Kindi.API.Application.Resources;
using Microsoft.Extensions.Localization;

namespace Kindi.API.Application.Common.Interfaces;

public interface IExcelService
{
	byte[] ExportToExcel<T>(
		IEnumerable<T> data,
		Dictionary<string, Func<T, object>> columnConfig,
		string sheetName,
		string titleKey,
		IStringLocalizer<SharedResource> localizer);
}