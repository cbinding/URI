/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: URI
Classes	: SKOSXL
License : http://creativecommons.org/licenses/by/3.0/ 
================================================================================
History :

14/08/2011  CFB Created class(es)
================================================================================
*/
using System;

namespace URI
{
    /// <summary>
    /// Defines RDF namespace, entity and property URI constants for SKOS-XL model
    /// </summary>
    /// <example> This sample code shows how use the constants defined in the class
    /// <code>
    /// // C# example:
    /// String s = URI.SKOSXL.PREFLABEL; 
    /// // = http://www.w3.org/2008/05/skos-xl#prefLabel
    /// </code>
    ///</example>
    public static class SKOSXL
    {        
        #region namespace
        /// <summary>http://www.w3.org/2008/05/skos-xl#</summary>
        public const String NS = "http://www.w3.org/2008/05/skos-xl#";
        //public const String NS_PREFIX = "skosxl";
        #endregion

        #region entities
        /// <summary>http://www.w3.org/2008/05/skos-xl#Label</summary>
        public const String LABEL = NS + "Label";
        #endregion

        #region properties
        /// <summary>http://www.w3.org/2008/05/skos-xl#prefLabel</summary>
        public const String PREFLABEL = NS + "prefLabel";
        /// <summary>http://www.w3.org/2008/05/skos-xl#altLabel</summary>
        public const String ALTLABEL = NS + "altLabel";
        /// <summary>http://www.w3.org/2008/05/skos-xl#hiddenLabel</summary>
        public const String HIDDENLABEL = NS + "hiddenLabel";
        /// <summary>http://www.w3.org/2008/05/skos-xl#labelRelation</summary>
        public const String LABELRELATION = NS + "labelRelation";
        /// <summary>http://www.w3.org/2008/05/skos-xl#literalForm</summary>
        public const String LITERALFORM = NS + "literalForm";
        #endregion
    }
}
