/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: URI
Classes	: SKOS
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
    /// Defines RDF namespace, entity and property URI constants for SKOS model
    /// </summary>
    /// <example> This sample code shows how use the constants defined in the class
    /// <code>
    /// // C# example:
    /// String s = URI.SKOS.CONCEPT; 
    /// // = http://www.w3.org/2004/02/skos/core#Concept
    /// </code>
    ///</example>
    public static class SKOS
    {
        #region namespace
        /// <summary>http://www.w3.org/2004/02/skos/core#</summary>
        public const String NS = "http://www.w3.org/2004/02/skos/core#";
        //public const String NS_PREFIX = "skos";
        #endregion

        #region entities
        /// <summary>http://www.w3.org/2004/02/skos/core#CollectableProperty</summary>
        public const String COLLECTABLEPROPERTY = NS + "CollectableProperty";
        /// <summary>http://www.w3.org/2004/02/skos/core#Collection</summary>
        public const String COLLECTION = NS + "Collection";
        /// <summary>http://www.w3.org/2004/02/skos/core#Concept</summary>
        public const String CONCEPT = NS + "Concept";
        /// <summary>http://www.w3.org/2004/02/skos/core#ConceptScheme</summary>
        public const String CONCEPTSCHEME = NS + "ConceptScheme";
        /// <summary>http://www.w3.org/2004/02/skos/core#OrderedCollection</summary>
        public const String ORDEREDCOLLECTION = NS + "OrderedCollection";
        #endregion

        #region properties
        /// <summary>http://www.w3.org/2004/02/skos/core#altLabel</summary>
        public const String ALTLABEL = NS + "altLabel";
        /// <summary>http://www.w3.org/2004/02/skos/core#altSymbol</summary>
        public const String ALTSYMBOL = NS + "altSymbol";
        /// <summary>http://www.w3.org/2004/02/skos/core#broader</summary>
        public const String BROADER = NS + "broader";
        /// <summary>http://www.w3.org/2004/02/skos/core#changeNote</summary>
        public const String CHANGENOTE = NS + "changeNote";
        /// <summary>http://www.w3.org/2004/02/skos/core#definition</summary>
        public const String DEFINITION = NS + "definition";
        /// <summary>http://www.w3.org/2004/02/skos/core#editorialNote</summary>
        public const String EDITORIALNOTE = NS + "editorialNote";
        /// <summary>http://www.w3.org/2004/02/skos/core#example</summary>
        public const String EXAMPLE = NS + "example";
        /// <summary>http://www.w3.org/2004/02/skos/core#hasTopConcept</summary>
        public const String HASTOPCONCEPT = NS + "hasTopConcept";
        /// <summary>http://www.w3.org/2004/02/skos/core#hiddenLabel</summary>
        public const String HIDDENLABEL = NS + "hiddenLabel";
        /// <summary>http://www.w3.org/2004/02/skos/core#historyNote</summary>
        public const String HISTORYNOTE = NS + "historyNote";
        /// <summary>http://www.w3.org/2004/02/skos/core#inScheme</summary>
        public const String INSCHEME = NS + "inScheme";
        /// <summary>http://www.w3.org/2004/02/skos/core#isPrimarySubjectOf</summary>
        public const String ISPRIMARYSUBJECTOF = NS + "isPrimarySubjectOf";
        /// <summary>http://www.w3.org/2004/02/skos/core#isSubjectOf</summary>
        public const String ISSUBJECTOF = NS + "isSubjectOf";
        /// <summary>http://www.w3.org/2004/02/skos/core#member</summary>
        public const String MEMBER = NS + "member";
        /// <summary>http://www.w3.org/2004/02/skos/core#memberList</summary>
        public const String MEMBERLIST = NS + "memberList";
        /// <summary>http://www.w3.org/2004/02/skos/core#narrower</summary>
        public const String NARROWER = NS + "narrower";
        /// <summary>http://www.w3.org/2004/02/skos/core#notation</summary>
        public const String NOTATION = NS + "notation";
        /// <summary>http://www.w3.org/2004/02/skos/core#note</summary>
        public const String NOTE = NS + "note";
        /// <summary>http://www.w3.org/2004/02/skos/core#prefLabel</summary>
        public const String PREFLABEL = NS + "prefLabel";
        /// <summary>http://www.w3.org/2004/02/skos/core#prefSymbol</summary>
        public const String PREFSYMBOL = NS + "prefSymbol";
        /// <summary>http://www.w3.org/2004/02/skos/core#primarySubject</summary>
        public const String PRIMARYSUBJECT = NS + "primarySubject";
        /// <summary>http://www.w3.org/2004/02/skos/core#related</summary>
        public const String RELATED = NS + "related";
        /// <summary>http://www.w3.org/2004/02/skos/core#scopeNote</summary>
        public const String SCOPENOTE = NS + "scopeNote";
        /// <summary>http://www.w3.org/2004/02/skos/core#semanticRelation</summary>
        public const String SEMANTICRELATION = NS + "semanticRelation";
        /// <summary>http://www.w3.org/2004/02/skos/core#subject</summary>
        public const String SUBJECT = NS + "subject";
        /// <summary>http://www.w3.org/2004/02/skos/core#subjectIndicator</summary>
        public const String SUBJECTINDICATOR = NS + "subjectIndicator";
        /// <summary>http://www.w3.org/2004/02/skos/core#symbol</summary>
        public const String SYMBOL = NS + "symbol";
        #endregion        
    }   
}
