#ifndef _URI_RDF_H 
#define _URI_RDF_H 

#define NS_RDF "http://www.w3.org/1999/02/22-rdf-syntax-ns#"    
      
namespace URI
{
	// usage: URI::RDF::TYPE, URI::RDF::VALUE etc.	
   namespace RDF
   {  
    // Entity types
    static const char XMLLITERAL[] = NS_RDF "XMLLiteral";	
	static const char PROPERTY[] = NS_RDF "Property";
	static const char STATEMENT[] = NS_RDF "Statement";
	static const char BAG[] = NS_RDF "Bag";
	static const char SEQ[] = NS_RDF "Seq";
	static const char ALT[] = NS_RDF "Alt";
	static const char LIST[] = NS_RDF "List";
	// Property types
	static const char TYPE[] = NS_RDF "type";
	static const char FIRST[] = NS_RDF "first";
	static const char REST[] = NS_RDF "rest";
	static const char VALUE[] = NS_RDF "value";
	static const char SUBJECT[] = NS_RDF "subject";
	static const char PREDICATE[] = NS_RDF "predicate";
	static const char OBJECT[] = NS_RDF "object";
	static const char ID[] = NS_RDF "ID";
   }    
}

#endif
