using GeekBrainsCSharpBasics.ExceptionsLibrary;
using System;

namespace GeekBrainsCSharpBasics
{
    public static class LoadDataExeptionHelper
    {
        public static bool TryLoadData<TData>(Func<TData> getData, out TData data)
        {
            data = default;
            try
            {
                data = getData();
            }
            catch (NotSupportInputDataFormatExeption exeption)
            {
                Console.WriteLine(exeption.Message);
                return false;
            }
            catch (UnregisteredDataProviderTypeExeption exeption)
            {
                Console.WriteLine(exeption.Message);
                return false;
            }
            catch (UnregisteredDataTypeException exeption)
            {
                Console.WriteLine(exeption.Message);
                return false;
            }
            return true;
        }
    }
}
