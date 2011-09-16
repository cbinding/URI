#ifndef _URI_OWL_H 
#define _URI_OWL_H 

#define NS_OWL "http://www.w3.org/2002/07/owl#"    
      
namespace URI
{
	// usage: URI::OWL::THING, URI::OWL::IMPORTS etc.	
   namespace OWL
   {  
    // Entity types
    static const char ALLDIFFERENT[] = NS_OWL "AllDifferent";
	static const char ANNOTATIONPROPERTY[] = NS_OWL "AnnotationProperty";
	static const char CLASS[] = NS_OWL "Class";
	static const char DATARANGE[] = NS_OWL "DataRange";
	static const char DATATYPEPROPERTY[] = NS_OWL "DatatypeProperty";
	static const char DEPRECATEDCLASS[] = NS_OWL "DeprecatedClass";
	static const char DEPRECATEDPROPERTY[] = NS_OWL "DeprecatedProperty";
	static const char FUNCTIONALPROPERTY[] = NS_OWL "FunctionalProperty";
	static const char INVERSEFUNCTIONALPROPERTY[] = NS_OWL "InverseFunctionalProperty";
	static const char NOTHING[] = NS_OWL "Nothing";
	static const char OBJECTPROPERTY[] = NS_OWL "ObjectProperty";
	static const char ONTOLOGY[] = NS_OWL "Ontology";
	static const char ONTOLOGYPROPERTY[] = NS_OWL "OntologyProperty";
	static const char RESTRICTION[] = NS_OWL "Restriction";
	static const char SYMMETRICPROPERTY[] = NS_OWL "SymmetricProperty";
	static const char THING[] = NS_OWL "Thing";
	static const char TRANSITIVEPROPERTY[] = NS_OWL "TransitiveProperty";
	// Property types
	static const char ALLVALUESFROM[] = NS_OWL "allValuesFrom";
	static const char BACKWARDCOMPATIBLEWITH[] = NS_OWL "backwardCompatibleWith";
	static const char CARDINALITY[] = NS_OWL "cardinality";
	static const char COMPLEMENTOF[] = NS_OWL "complementOf";
	static const char DIFFERENTFROM[] = NS_OWL "differentFrom";
	static const char DISJOINTWITH[] = NS_OWL "disjointWith";
	static const char DISTINCTMEMBERS[] = NS_OWL "distinctMembers";
	static const char EQUIVALENTCLASS[] = NS_OWL "equivalentClass";
	static const char EQUIVALENTPROPERTY[] = NS_OWL "equivalentProperty";
	static const char HASVALUE[] = NS_OWL "hasValue";
	static const char IMPORTS[] = NS_OWL "imports";
	static const char INCOMPATIBLEWITH[] = NS_OWL "incompatibleWith";
	static const char INTERSECTIONOF[] = NS_OWL "intersectionOf";
	static const char INVERSEOF[] = NS_OWL "inverseOf";
	static const char MAXCARDINALITY[] = NS_OWL "maxCardinality";
	static const char MINCARDINALITY[] = NS_OWL "minCardinality";
	static const char ONEOF[] = NS_OWL "oneOf";
	static const char ONPROPERTY[] = NS_OWL "onProperty";
	static const char PRIORVERSION[] = NS_OWL "priorVersion";
	static const char SAMEAS[] = NS_OWL "sameAs";
	static const char SOMEVALUESFROM[] = NS_OWL "someValuesFrom";
	static const char UNIONOF[] = NS_OWL "unionOf";
	static const char VERSIONINFO[] = NS_OWL "versionInfo";
   }    
}

#endif
