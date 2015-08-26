using System;

namespace Spreadsheet.Core.Cells
{
    public class CellRefereceExpression : IExpression
    {
        public CellAddress Address { get; }

        public CellRefereceExpression(CellAddress address)
        {
            Address = address;
        }

        public object Evaluate(ISpreadsheetProcessor processor)
        {
            var result = processor.GetCellValue(Address);
            var exception = result as Exception;
            if (exception != null)
                throw exception;
            return result;
        }

        public override string ToString() => Address.StringValue;
    }
}