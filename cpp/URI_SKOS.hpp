#ifndef _URI_SKOS_H 
#define _URI_SKOS_H 
/*
URI Constants for SKOS
Ceri Binding, University of Glamorgan

Date          Who  Description
----          ---  -----------
06/04/2011    CFB  Initially created constants
*/

#define NS_SKOS "http://www.w3.org/2004/02/skos/core#"    
      
namespace URI
{
   namespace SKOS
   {  
      //usage: URI::SKOS::CONCEPT, URI::SKOS::BROADER etc.
      static const char COLLECTABLEPROPERTY[] = NS_SKOS "CollectableProperty";
      static const char COLLECTION[] = NS_SKOS "Collection";
      static const char CONCEPT[] = NS_SKOS "Concept";
      static const char CONCEPTSCHEME[] = NS_SKOS "ConceptScheme";
      static const char ORDEREDCOLLECTION[] = NS_SKOS "OrderedCollection";

      static const char ALTLABEL[] = NS_SKOS "altLabel";
      static const char ALTSYMBOL[] = NS_SKOS "altSymbol";
      static const char BROADER[] = NS_SKOS "broader";
      static const char CHANGENOTE[] = NS_SKOS "changeNote";
      static const char DEFINITION[] = NS_SKOS "definition";
      static const char EDITORIALNOTE[] = NS_SKOS "editorialNote";
      static const char EXAMPLE[] = NS_SKOS "example";
      static const char HASTOPCONCEPT[] = NS_SKOS "hasTopConcept";
      static const char HIDDENLABEL[] = NS_SKOS "hiddenLabel";
      static const char HISTORYNOTE[] = NS_SKOS "historyNote";
      static const char INSCHEME[] = NS_SKOS "inScheme";
      static const char ISPRIMARYSUBJECTOF[] = NS_SKOS "isPrimarySubjectOf";
      static const char ISSUBJECTOF[] = NS_SKOS "isSubjectOf";
      static const char MEMBER[] = NS_SKOS "member";
      static const char MEMBERLIST[] = NS_SKOS "memberList";
      static const char NARROWER[] = NS_SKOS "narrower";
      static const char NOTATION[] = NS_SKOS "notation";
      static const char NOTE[] = NS_SKOS "note";
      static const char PREFLABEL[] = NS_SKOS "prefLabel";
      static const char PREFSYMBOL[] = NS_SKOS "prefSymbol";
      static const char PRIMARYSUBJECT[] = NS_SKOS "primarySubject";
      static const char RELATED[] = NS_SKOS "related";
      static const char SCOPENOTE[] = NS_SKOS "scopeNote";
      static const char SEMANTICRELATION[] = NS_SKOS "semanticRelation";
      static const char SUBJECT[] = NS_SKOS "subject";
      static const char SUBJECTINDICATOR[] = NS_SKOS "subjectIndicator";
      static const char SYMBOL[] = NS_SKOS "symbol";
   }
}

#endif
