/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: URI
Classes	: DCTERMS
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
    /// Defines RDF namespace, entity and property URI constants for Dublin Core Terms model
    /// </summary>
    /// <example> This sample code shows how use the constants defined in the class
    /// <code>
    /// // C# example:
    /// String s = URI.DCTERMS.TITLE;
    /// // = http://purl.org/dc/terms/title
    /// </code>
    ///</example>
    public static class DCTERMS
    {
        #region namespace
        /// <summary>http://purl.org/dc/terms/</summary>
        public const String NS = "http://purl.org/dc/terms/";
        //public const String NS_PREFIX = "dcterms";
        #endregion

        #region entities
        /// <summary>http://purl.org/dc/terms/SubjectScheme</summary>
        public const String SUBJECTSCHEME = NS + "SubjectScheme";
        /// <summary>http://purl.org/dc/terms/DateScheme</summary>
        public const String DATESCHEME = NS + "DateScheme";
        /// <summary>http://purl.org/dc/terms/FormatScheme</summary>
        public const String FORMATSCHEME = NS + "FormatScheme";
        /// <summary>http://purl.org/dc/terms/LanguageScheme</summary>
        public const String LANGUAGESCHEME = NS + "LanguageScheme";
        /// <summary>http://purl.org/dc/terms/SpatialScheme</summary>
        public const String SPATIALSCHEME = NS + "SpatialScheme";
        /// <summary>http://purl.org/dc/terms/TemporalScheme"</summary>
        public const String TEMPORALSCHEME = NS + "TemporalScheme";
        /// <summary>http://purl.org/dc/terms/TypeScheme</summary>
        public const String TYPESCHEME = NS + "TypeScheme";
        /// <summary>http://purl.org/dc/terms/IdentifierScheme</summary>
        public const String IDENTIFIERSCHEME = NS + "IdentifierScheme";
        /// <summary>http://purl.org/dc/terms/RelationScheme</summary>
        public const String RELATIONSCHEME = NS + "RelationScheme";
        /// <summary>http://purl.org/dc/terms/SourceScheme</summary>
        public const String SOURCESCHEME = NS + "SourceScheme";
        #endregion

        #region properties
        /// <summary>http://purl.org/dc/terms/audience</summary>
        public const String AUDIENCE = NS + "audience";
        /// <summary>http://purl.org/dc/terms/alternative</summary>
        public const String ALTERNATIVE = NS + "alternative";
        /// <summary>http://purl.org/dc/terms/tableOfContents</summary>
        public const String TABLEOFCONTENTS = NS + "tableOfContents";
        /// <summary>http://purl.org/dc/terms/abstract</summary>
        public const String ABSTRACT = NS + "abstract";
        /// <summary>http://purl.org/dc/terms/created</summary>
        public const String CREATED = NS + "created";
        /// <summary>http://purl.org/dc/terms/valid</summary>
        public const String VALID = NS + "valid";
        /// <summary>http://purl.org/dc/terms/available</summary>
        public const String AVAILABLE = NS + "available";
        /// <summary>http://purl.org/dc/terms/issued</summary>
        public const String ISSUED = NS + "issued";
        /// <summary>http://purl.org/dc/terms/modified</summary>
        public const String MODIFIED = NS + "modified";
        /// <summary>http://purl.org/dc/terms/extent</summary>
        public const String EXTENT = NS + "extent";
        /// <summary>http://purl.org/dc/terms/medium</summary>
        public const String MEDIUM = NS + "medium";
        /// <summary>http://purl.org/dc/terms/isVersionOf</summary>
        public const String ISVERSIONOF = NS + "isVersionOf";
        /// <summary>http://purl.org/dc/terms/hasVersion</summary>
        public const String HASVERSION = NS + "hasVersion";
        /// <summary>http://purl.org/dc/terms/isReplacedBy</summary>
        public const String ISREPLACEDBY = NS + "isReplacedBy";
        /// <summary>http://purl.org/dc/terms/replaces</summary>
        public const String REPLACES = NS + "replaces";
        /// <summary>http://purl.org/dc/terms/isRequiredBy</summary>
        public const String ISREQUIREDBY = NS + "isRequiredBy";
        /// <summary>http://purl.org/dc/terms/requires</summary>
        public const String REQUIRES = NS + "requires";
        /// <summary>http://purl.org/dc/terms/isPartOf</summary>
        public const String ISPARTOF = NS + "isPartOf";
        /// <summary>http://purl.org/dc/terms/hasPart</summary>
        public const String HASPART = NS + "hasPart";
        /// <summary>http://purl.org/dc/terms/isReferencedBy</summary>
        public const String ISREFERENCEDBY = NS + "isReferencedBy";
        /// <summary>http://purl.org/dc/terms/references</summary>
        public const String REFERENCES = NS + "references";
        /// <summary>http://purl.org/dc/terms/isFormatOf</summary>
        public const String ISFORMATOF = NS + "isFormatOf";
        /// <summary>http://purl.org/dc/terms/hasFormat</summary>
        public const String HASFORMAT = NS + "hasFormat";
        /// <summary>http://purl.org/dc/terms/conformsTo</summary>
        public const String CONFORMSTO = NS + "conformsTo";
        /// <summary>http://purl.org/dc/terms/spatial</summary>
        public const String SPATIAL = NS + "spatial";
        /// <summary>http://purl.org/dc/terms/temporal</summary>
        public const String TEMPORAL = NS + "temporal";
        /// <summary>http://purl.org/dc/terms/mediator</summary>
        public const String MEDIATOR = NS + "mediator";
        /// <summary>http://purl.org/dc/terms/dateAccepted</summary>
        public const String DATEACCEPTED = NS + "dateAccepted";
        /// <summary>http://purl.org/dc/terms/dateCopyrighted</summary>
        public const String DATECOPYRIGHTED = NS + "dateCopyrighted";
        /// <summary>http://purl.org/dc/terms/dateSubmitted</summary>
        public const String DATESUBMITTED = NS + "dateSubmitted";
        /// <summary>http://purl.org/dc/terms/educationLevel</summary>
        public const String EDUCATIONLEVEL = NS + "educationLevel";
        /// <summary>http://purl.org/dc/terms/accessRights</summary>
        public const String ACCESSRIGHTS = NS + "accessRights";
        /// <summary>http://purl.org/dc/terms/bibliographicCitation</summary>
        public const String BIBLIOGRAPHICCITATION = NS + "bibliographicCitation";
        /// <summary>http://purl.org/dc/terms/license</summary>
        public const String LICENSE = NS + "license";
        /// <summary>http://purl.org/dc/terms/rightsHolder</summary>
        public const String RIGHTSHOLDER = NS + "rightsHolder";
        /// <summary>http://purl.org/dc/terms/provenance</summary>
        public const String PROVENANCE = NS + "provenance";
        /// <summary>http://purl.org/dc/terms/instructionalMethod</summary>
        public const String INSTRUCTIONALMETHOD = NS + "instructionalMethod";
        /// <summary>http://purl.org/dc/terms/accrualMethod</summary>
        public const String ACCRUALMETHOD = NS + "accrualMethod";
        /// <summary>http://purl.org/dc/terms/accrualPeriodicity</summary>
        public const String ACCRUALPERIODICITY = NS + "accrualPeriodicity";
        /// <summary>http://purl.org/dc/terms/accrualPolicy</summary>
        public const String ACCRUALPOLICY = NS + "accrualPolicy";
        /// <summary>http://purl.org/dc/terms/title</summary>
        public const String TITLE = NS + "title";
        /// <summary>http://purl.org/dc/terms/creator</summary>
        public const String CREATOR = NS + "creator";
        /// <summary>http://purl.org/dc/terms/subject</summary>
        public const String SUBJECT = NS + "subject";
        /// <summary>http://purl.org/dc/terms/description</summary>
        public const String DESCRIPTION = NS + "description";
        /// <summary>http://purl.org/dc/terms/publisher</summary>
        public const String PUBLISHER = NS + "publisher";
        /// <summary>http://purl.org/dc/terms/contributor</summary>
        public const String CONTRIBUTOR = NS + "contributor";
        /// <summary>http://purl.org/dc/terms/date</summary>
        public const String DATE = NS + "date";
        /// <summary>http://purl.org/dc/terms/type</summary>
        public const String TYPE = NS + "type";
        /// <summary>http://purl.org/dc/terms/format</summary>
        public const String FORMAT = NS + "format";
        /// <summary>http://purl.org/dc/terms/identifier</summary>
        public const String IDENTIFIER = NS + "identifier";
        /// <summary>http://purl.org/dc/terms/source</summary>
        public const String SOURCE = NS + "source";
        /// <summary>http://purl.org/dc/terms/language</summary>
        public const String LANGUAGE = NS + "language";
        /// <summary>http://purl.org/dc/terms/relation</summary>
        public const String RELATION = NS + "relation";
        /// <summary>http://purl.org/dc/terms/coverage</summary>
        public const String COVERAGE = NS + "coverage";
        /// <summary>http://purl.org/dc/terms/rights</summary>
        public const String RIGHTS = NS + "rights";
        #endregion        
    }  
}
