#ifndef _URI_SKOSXL_H 
#define _URI_SKOSXL_H 
/*
URI Constants for SKOS-XL
Ceri Binding, University of Glamorgan

Date          Who  Description
----          ---  -----------
06/04/2011    CFB  Initially created constants
*/

#define NS_SKOSXL "http://www.w3.org/2008/05/skos-xl#"    
      
namespace URI
{
   namespace SKOSXL
   {  
      // usage: URI::SKOSXL::LABEL, URI::SKOSXL::LABELRELATION etc.
      static const char LABEL[] = NS_SKOSXL "Label";
	  static const char PREFLABEL[] = NS_SKOSXL "prefLabel";
	  static const char ALTLABEL[] = NS_SKOSXL "altLabel";
	  static const char HIDDENLABEL[] = NS_SKOSXL "hiddenLabel";
	  static const char LABELRELATION[] = NS_SKOSXL "labelRelation";
	  static const char LITERALFORM[] = NS_SKOSXL "literalForm";      
   }
}

#endif
