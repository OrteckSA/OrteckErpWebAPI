using System.Dynamic;

namespace ERP.WebAPI.Extensions
{
    public static class GeneralExtentions
    {
        public static T ToObject<T>(this object obj) where T : class, new()
        {
            var result = new T();

            if(obj is ExpandoObject expando)
            {
                foreach (var property in expando)
                {
                    var propInfo = result.GetType().GetProperty(property.Key);
                    if (propInfo != null)
                    {
                        propInfo.SetValue(result, property.Value);
                    }
                }
                return result;
            }

            foreach (var property in obj.GetType().GetProperties())
            {
                var propInfo = result.GetType().GetProperty(property.Name);
                if (propInfo != null)
                {
                    propInfo.SetValue(result, property.GetValue(obj));
                }
            }

            return result;
        }
    }
}
