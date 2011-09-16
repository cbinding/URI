/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: URI
Classes	: DC
License : http://creativecommons.org/licenses/by/3.0/ 
================================================================================
History :

06/05/2011  CFB Created class(es)
================================================================================
*/
using System;

namespace URI
{
    /// <summary>
    /// Defines RDF namespace, entity and property URI constants for Dublin Core model
    /// </summary>
    /// <example> This sample code shows how use the constants defined in the class
    /// <code>
    /// // C# example:
    /// String s = URI.DC.TITLE;
    /// // = http://purl.org/dc/elements/1.1/title    
    /// </code>
    ///</example>
    public static class DC
    {
        #region namespace
        /// <summary>http://purl.org/dc/elements/1.1/</summary>
        public const String NS = "http://purl.org/dc/elements/1.1/";
        //public const String NS_PREFIX = "dc";
        #endregion

        #region properties
        /// <summary>http://purl.org/dc/elements/1.1/title</summary>
        public const String TITLE = NS + "title";
        /// <summary>http://purl.org/dc/elements/1.1/creator</summary>
        public const String CREATOR = NS + "creator";
        /// <summary>http://purl.org/dc/elements/1.1/subject</summary>
        public const String SUBJECT = NS + "subject";
        /// <summary>http://purl.org/dc/elements/1.1/description</summary>
        public const String DESCRIPTION = NS + "description";
        /// <summary>http://purl.org/dc/elements/1.1/publisher</summary>
        public const String PUBLISHER = NS + "publisher";
        /// <summary>http://purl.org/dc/elements/1.1/contributor</summary>
        public const String CONTRIBUTOR = NS + "contributor";
        /// <summary>http://purl.org/dc/elements/1.1/date</summary>
        public const String DATE = NS + "date";
        /// <summary>http://purl.org/dc/elements/1.1/type</summary>
        public const String TYPE = NS + "type";
        /// <summary>http://purl.org/dc/elements/1.1/format</summary>
        public const String FORMAT = NS + "format";
        /// <summary>http://purl.org/dc/elements/1.1/identifier</summary>
        public const String IDENTIFIER = NS + "identifier";
        /// <summary>http://purl.org/dc/elements/1.1/source</summary>
        public const String SOURCE = NS + "source";
        /// <summary>http://purl.org/dc/elements/1.1/language</summary>
        public const String LANGUAGE = NS + "language";
        /// <summary>http://purl.org/dc/elements/1.1/relation</summary>
        public const String RELATION = NS + "relation";
        /// <summary>http://purl.org/dc/elements/1.1/coverage</summary>
        public const String COVERAGE = NS + "coverage";
        /// <summary>http://purl.org/dc/elements/1.1/rights</summary>
        public const String RIGHTS = NS + "rights";
        #endregion
    }
}
