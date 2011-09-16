#ifndef _URI_RDFS_H 
#define _URI_RDFS_H 

#define NS_RDFS "http://www.w3.org/2000/01/rdf-schema#"    
      
namespace URI
{
	// usage: URI::RDFS::RESOURCE, URI::RDFS::SUBCLASSOF etc.	
   namespace RDFS
   {  
    // Entity types
    static const char RESOURCE[] = NS_RDFS "Resource";	
	static const char LITERAL[] = NS_RDFS "Literal";
	static const char CLASS[] = NS_RDFS "Class";
	static const char DATATYPE[] = NS_RDFS "Datatype";
	static const char CONTAINER[] = NS_RDFS "Container";
	static const char CONTAINERMEMBERSHIPPROPERTY[] = NS_RDFS "ContainerMembershipProperty";
	// Property types
	static const char SUBCLASSOF[] = NS_RDFS "subClassOf";
	static const char SUBPROPERTYOF[] = NS_RDFS "subPropertyOf";
	static const char DOMAIN[] = NS_RDFS "domain";
	static const char RANGE[] = NS_RDFS "range";
	static const char LABEL[] = NS_RDFS "label";
	static const char COMMENT[] = NS_RDFS "comment";
	static const char MEMBER[] = NS_RDFS "member";
	static const char SEEALSO[] = NS_RDFS "seeAlso";
	static const char ISDEFINEDBY[] = NS_RDFS "isDefinedBy";
   }    
}

#endif
