﻿namespace uformsia.app.Forms
{

    // Namespaces.
    using System;


    /// <summary>
    /// Information attached to a form field.
    /// </summary>
    public class FormFieldMetaInfo<T> : IFormFieldMetaInfo
    {

        #region Properties

        /// <summary>
        /// The alias of this field meta information.
        /// </summary>
        public string Alias { get; set; }


        /// <summary>
        /// The name of this field meta information.
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// The data stored by this form field meta information.
        /// </summary>
        public T Data { get; set; }


        /// <summary>
        /// The type of data stored by this field meta information.
        /// </summary>
        public Type ValueType
        {
            get
            {
                return typeof(T);
            }
        }

        #endregion

    }

}