/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: URI
Classes	: RDF
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
    /// Defines RDF namespace, entity and property URI constants for RDF model
    /// </summary>
    /// <example> This sample code shows how use the constants defined in the class
    /// <code>
    /// // C# example:
    /// String s = URI.RDF.PROPERTY;
    /// // = http://www.w3.org/1999/02/22-rdf-syntax-ns#Property 
    /// </code>
    ///</example>
    public static class RDF
    {        
        #region namespace
        /// <summary>http://www.w3.org/1999/02/22-rdf-syntax-ns#</summary>
        public const String NS = "http://www.w3.org/1999/02/22-rdf-syntax-ns#";
        //public const String NS_PREFIX = "rdf";
        #endregion

        #region entities
        /// <summary>http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral</summary>
        public const String XMLLITERAL = NS + "XMLLiteral";
        /// <summary>http://www.w3.org/1999/02/22-rdf-syntax-ns#Property</summary>
        public const String PROPERTY = NS + "Property";
        /// <summary>http://www.w3.org/1999/02/22-rdf-syntax-ns#Statement</summary>
        public const String STATEMENT = NS + "Statement";
        /// <summary>http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag</summary>
        public const String BAG = NS + "Bag";
        /// <summary>http://www.w3.org/1999/02/22-rdf-syntax-ns#Seq</summary>
        public const String SEQ = NS + "Seq";
        /// <summary>http://www.w3.org/1999/02/22-rdf-syntax-ns#Alt</summary>
        public const String ALT = NS + "Alt";
        /// <summary>http://www.w3.org/1999/02/22-rdf-syntax-ns#List</summary>
        public const String LIST = NS + "List";
        #endregion

        #region properties
        /// <summary>http://www.w3.org/1999/02/22-rdf-syntax-ns#type</summary>
        public const String TYPE = NS + "type";
        /// <summary>http://www.w3.org/1999/02/22-rdf-syntax-ns#first</summary>
        public const String FIRST = NS + "first";
        /// <summary>http://www.w3.org/1999/02/22-rdf-syntax-ns#rest</summary>
        public const String REST = NS + "rest";
        /// <summary>http://www.w3.org/1999/02/22-rdf-syntax-ns#value</summary>
        public const String VALUE = NS + "value";
        /// <summary>http://www.w3.org/1999/02/22-rdf-syntax-ns#subject</summary>
        public const String SUBJECT = NS + "subject";
        /// <summary>http://www.w3.org/1999/02/22-rdf-syntax-ns#predicate</summary>
        public const String PREDICATE = NS + "predicate";
        /// <summary>http://www.w3.org/1999/02/22-rdf-syntax-ns#object</summary>
        public const String OBJECT = NS + "object";
        /// <summary>http://www.w3.org/1999/02/22-rdf-syntax-ns#ID</summary>
        public const String ID = NS + "ID";
        #endregion
    }   
}
