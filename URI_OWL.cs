/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: URI
Classes	: OWL
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
    /// Defines RDF namespace, entity and property URI constants for OWL model
    /// </summary>
    /// <example> This sample code shows how use the constants defined in the class
    /// <code>
    /// // C# example:
    /// String s = URI.OWL.CLASS;
    /// // = http://www.w3.org/2002/07/owl#Class 
    /// </code>
    ///</example>
    public static class OWL
    {
        #region namespace
        /// <summary>http://www.w3.org/2002/07/owl#</summary>
        public const String NS = "http://www.w3.org/2002/07/owl#";
        //public const String NS_PREFIX = "owl";
        #endregion

        #region entities
        /// <summary>http://www.w3.org/2002/07/owl#AllDifferent</summary>
        public const String ALLDIFFERENT = NS + "AllDifferent";
        /// <summary>http://www.w3.org/2002/07/owl#AnnotationProperty</summary>
        public const String ANNOTATIONPROPERTY = NS + "AnnotationProperty";
        /// <summary>http://www.w3.org/2002/07/owl#Class</summary>
        public const String CLASS = NS + "Class";
        /// <summary>http://www.w3.org/2002/07/owl#DataRange</summary>
        public const String DATARANGE = NS + "DataRange";
        /// <summary>http://www.w3.org/2002/07/owl#DatatypeProperty</summary>
        public const String DATATYPEPROPERTY = NS + "DatatypeProperty";
        /// <summary>http://www.w3.org/2002/07/owl#DeprecatedClass</summary>
        public const String DEPRECATEDCLASS = NS + "DeprecatedClass";
        /// <summary>http://www.w3.org/2002/07/owl#DeprecatedProperty</summary>
        public const String DEPRECATEDPROPERTY = NS + "DeprecatedProperty";
        /// <summary>http://www.w3.org/2002/07/owl#FunctionalProperty</summary>
        public const String FUNCTIONALPROPERTY = NS + "FunctionalProperty";
        /// <summary>http://www.w3.org/2002/07/owl#InverseFunctionalProperty</summary>
        public const String INVERSEFUNCTIONALPROPERTY = NS + "InverseFunctionalProperty";
        /// <summary>http://www.w3.org/2002/07/owl#Nothing</summary>
        public const String NOTHING = NS + "Nothing";
        /// <summary>http://www.w3.org/2002/07/owl#ObjectProperty</summary>
        public const String OBJECTPROPERTY = NS + "ObjectProperty";
        /// <summary>http://www.w3.org/2002/07/owl#Ontology</summary>
        public const String ONTOLOGY = NS + "Ontology";
        /// <summary>http://www.w3.org/2002/07/owl#OntologyProperty</summary>
        public const String ONTOLOGYPROPERTY = NS + "OntologyProperty";
        /// <summary>http://www.w3.org/2002/07/owl#Restriction</summary>
        public const String RESTRICTION = NS + "Restriction";
        /// <summary>http://www.w3.org/2002/07/owl#SymmetricProperty</summary>
        public const String SYMMETRICPROPERTY = NS + "SymmetricProperty";
        /// <summary>http://www.w3.org/2002/07/owl#Thing</summary>
        public const String THING = NS + "Thing";
        /// <summary>http://www.w3.org/2002/07/owl#TransitiveProperty</summary>
        public const String TRANSITIVEPROPERTY = NS + "TransitiveProperty";
        #endregion

        #region properties
        /// <summary>http://www.w3.org/2002/07/owl#allValuesFrom</summary>
        public const String ALLVALUESFROM = NS + "allValuesFrom";
        /// <summary>http://www.w3.org/2002/07/owl#backwardCompatibleWith</summary>
        public const String BACKWARDCOMPATIBLEWITH = NS + "backwardCompatibleWith";
        /// <summary>http://www.w3.org/2002/07/owl#cardinality</summary>
        public const String CARDINALITY = NS + "cardinality";
        /// <summary>http://www.w3.org/2002/07/owl#complementOf</summary>
        public const String COMPLEMENTOF = NS + "complementOf";
        /// <summary>http://www.w3.org/2002/07/owl#differentFrom</summary>
        public const String DIFFERENTFROM = NS + "differentFrom";
        /// <summary>http://www.w3.org/2002/07/owl#disjointWith</summary>
        public const String DISJOINTWITH = NS + "disjointWith";
        /// <summary>http://www.w3.org/2002/07/owl#distinctMembers</summary>
        public const String DISTINCTMEMBERS = NS + "distinctMembers";
        /// <summary>http://www.w3.org/2002/07/owl#equivalentClass</summary>
        public const String EQUIVALENTCLASS = NS + "equivalentClass";
        /// <summary>http://www.w3.org/2002/07/owl#equivalentProperty</summary>
        public const String EQUIVALENTPROPERTY = NS + "equivalentProperty";
        /// <summary>http://www.w3.org/2002/07/owl#hasValue</summary>
        public const String HASVALUE = NS + "hasValue";
        /// <summary>http://www.w3.org/2002/07/owl#imports</summary>
        public const String IMPORTS = NS + "imports";
        /// <summary>http://www.w3.org/2002/07/owl#incompatibleWith</summary>
        public const String INCOMPATIBLEWITH = NS + "incompatibleWith";
        /// <summary>http://www.w3.org/2002/07/owl#intersectionOf</summary>
        public const String INTERSECTIONOF = NS + "intersectionOf";
        /// <summary>http://www.w3.org/2002/07/owl#inverseOf</summary>
        public const String INVERSEOF = NS + "inverseOf";
        /// <summary>http://www.w3.org/2002/07/owl#maxCardinality</summary>
        public const String MAXCARDINALITY = NS + "maxCardinality";
        /// <summary>http://www.w3.org/2002/07/owl#minCardinality</summary>
        public const String MINCARDINALITY = NS + "minCardinality";
        /// <summary>http://www.w3.org/2002/07/owl#oneOf</summary>
        public const String ONEOF = NS + "oneOf";
        /// <summary>http://www.w3.org/2002/07/owl#onProperty</summary>
        public const String ONPROPERTY = NS + "onProperty";
        /// <summary>http://www.w3.org/2002/07/owl#priorVersion</summary>
        public const String PRIORVERSION = NS + "priorVersion";
        /// <summary>http://www.w3.org/2002/07/owl#sameAs</summary>
        public const String SAMEAS = NS + "sameAs";
        /// <summary>http://www.w3.org/2002/07/owl#someValuesFrom</summary>
        public const String SOMEVALUESFROM = NS + "someValuesFrom";
        /// <summary>http://www.w3.org/2002/07/owl#unionOf</summary>
        public const String UNIONOF = NS + "unionOf";
        /// <summary>http://www.w3.org/2002/07/owl#versionInfo</summary>
        public const String VERSIONINFO = NS + "versionInfo";
        #endregion        
    }   
}
