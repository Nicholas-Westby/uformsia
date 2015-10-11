﻿namespace uformsia.app.Forms
{

    // Namespaces.
    using System;
    using System.Collections.Generic;


    /// <summary>
    /// Stores information about a form field.
    /// </summary>
    /// <typeparam name="T">The type of data stored by this form field.</typeparam>
    public class FormField<T>
    {

        #region Properties

        /// <summary>
        /// The unique ID of the field.
        /// </summary>
        public Guid Id { get; set; }


        /// <summary>
        /// The alias of the field.
        /// </summary>
        public string Alias { get; set; }


        /// <summary>
        /// The name of the field.
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// The type of data stored by the field.
        /// </summary>
        public Type GetFieldType
        {
            get
            {
                return typeof(T);
            }
        }


        /// <summary>
        /// Information about the field.
        /// </summary>
        public IEnumerable<IFormFieldMetaInfo> MetaInfo { get; set; }

        #endregion

    }

}