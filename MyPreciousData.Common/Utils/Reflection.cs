﻿using System;
using System.Reflection;

namespace MyPreciousData.Utils
{
  // https://stackoverflow.com/questions/930433/apply-properties-values-from-one-object-to-another-of-the-same-type-automaticall
  /// <summary>
  /// A static class for reflection type functions
  /// </summary>
  public static class Reflection
  {
    /// <summary>
    /// Extension for 'Object' that copies the properties to a destination object.
    /// </summary>
    /// <param name="source">The source.</param>
    /// <param name="destination">The destination.</param>
    public static void CopyProperties(this object source, object destination)
    {
      // If any this null throw an exception
      if (source == null || destination == null)
        throw new Exception("Source or/and Destination Objects are null");
      // Getting the Types of the objects
      Type typeDest = destination.GetType();
      Type typeSrc = source.GetType();

      // Iterate the Properties of the source instance and  
      // populate them from their desination counterparts  
      PropertyInfo[] srcProps = typeSrc.GetProperties();
      foreach (PropertyInfo srcProp in srcProps)
      {
        if (!srcProp.CanRead)
        {
          continue;
        }
        PropertyInfo targetProperty = typeDest.GetProperty(srcProp.Name);
        if (targetProperty == null)
        {
          continue;
        }
        if (!targetProperty.CanWrite)
        {
          continue;
        }
        if (targetProperty.GetSetMethod(true) != null && targetProperty.GetSetMethod(true).IsPrivate)
        {
          continue;
        }
        if ((targetProperty.GetSetMethod().Attributes & MethodAttributes.Static) != 0)
        {
          continue;
        }
        if (!targetProperty.PropertyType.IsAssignableFrom(srcProp.PropertyType))
        {
          continue;
        }
        // Passed all tests, lets set the value
        targetProperty.SetValue(destination, srcProp.GetValue(source, null), null);
      }
    }
  }
}
