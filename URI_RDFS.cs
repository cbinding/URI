/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: URI
Classes	: RDFS
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
    /// Defines RDF namespace, entity and property URI constants for RDFS model
    /// </summary>
    /// <example> This sample code shows how use the constants defined in the class
    /// <code>
    /// // C# example:
    /// String s = URI.RDFS.SUBCLASSOF;
    /// // = http://www.w3.org/2000/01/rdf-schema#subClassOf
    /// </code>
    ///</example>
    public static class RDFS
    {        
        #region namespace
        /// <summary>http://www.w3.org/2000/01/rdf-schema#</summary>
        public const String NS = "http://www.w3.org/2000/01/rdf-schema#";
        //public const String NS_PREFIX = "rdfs";
        #endregion

        #region entities
        /// <summary>http://www.w3.org/2000/01/rdf-schema#Resource</summary>
        public const String RESOURCE = NS + "Resource";
        /// <summary>http://www.w3.org/2000/01/rdf-schema#Literal</summary>
        public const String LITERAL = NS + "Literal";
        /// <summary>http://www.w3.org/2000/01/rdf-schema#Class</summary>
        public const String CLASS = NS + "Class";
        /// <summary>http://www.w3.org/2000/01/rdf-schema#Datatype</summary>
        public const String DATATYPE = NS + "Datatype";
        /// <summary>http://www.w3.org/2000/01/rdf-schema#Container</summary>
        public const String CONTAINER = NS + "Container";
        /// <summary>http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty</summary>
        public const String CONTAINERMEMBERSHIPPROPERTY = NS + "ContainerMembershipProperty";
        #endregion

        #region properties
        /// <summary>http://www.w3.org/2000/01/rdf-schema#subClassOf</summary>
        public const String SUBCLASSOF = NS + "subClassOf";
        /// <summary>http://www.w3.org/2000/01/rdf-schema#subPropertyOf</summary>
        public const String SUBPROPERTYOF = NS + "subPropertyOf";
        /// <summary>http://www.w3.org/2000/01/rdf-schema#domain</summary>
        public const String DOMAIN = NS + "domain";
        /// <summary>http://www.w3.org/2000/01/rdf-schema#range</summary>
        public const String RANGE = NS + "range";
        /// <summary>http://www.w3.org/2000/01/rdf-schema#label</summary>
        public const String LABEL = NS + "label";
        /// <summary>http://www.w3.org/2000/01/rdf-schema#comment</summary>
        public const String COMMENT = NS + "comment";
        /// <summary>http://www.w3.org/2000/01/rdf-schema#member</summary>
        public const String MEMBER = NS + "member";
        /// <summary>http://www.w3.org/2000/01/rdf-schema#seeAlso</summary>
        public const String SEEALSO = NS + "seeAlso";
        /// <summary>http://www.w3.org/2000/01/rdf-schema#isDefinedBy</summary>
        public const String ISDEFINEDBY = NS + "isDefinedBy";
        #endregion
    }  
}
