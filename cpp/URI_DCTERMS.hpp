#ifndef _URI_DCTERMS_H 
#define _URI_DCTERMS_H 

#define NS_DCTERMS "http://purl.org/dc/terms/"    
      
namespace URI
{
   namespace DCTERMS
   {  
      //usage: URI::DCTERMS::SUBJECTSCHEME, URI::DCTERMS::LANGUAGESCHEME etc.
      // Entity types
	  static const char SUBJECTSCHEME[] = NS_DCTERMS "SubjectScheme";
      static const char DATESCHEME[] = NS_DCTERMS "DateScheme";
      static const char FORMATSCHEME[] = NS_DCTERMS "FormatScheme";
      static const char LANGUAGESCHEME[] = NS_DCTERMS "LanguageScheme";
      static const char SPATIALSCHEME[] = NS_DCTERMS "SpatialScheme";
      static const char TEMPORALSCHEME[] = NS_DCTERMS "TemporalScheme";
      static const char TYPESCHEME[] = NS_DCTERMS"TypeScheme";
      static const char IDENTIFIERSCHEME[] = NS_DCTERMS "IdentifierScheme";
      static const char RELATIONSCHEME[] = NS_DCTERMS "RelationScheme";
      static const char SOURCESCHEME[] = NS_DCTERMS "SourceScheme";
	  // Property types
      static const char AUDIENCE[] = NS_DCTERMS "audience";
      static const char ALTERNATIVE[] = NS_DCTERMS "alternative";
      static const char TABLEOFCONTENTS[] = NS_DCTERMS "tableOfContents";
      static const char ABSTRACT[] = NS_DCTERMS "abstract";
      static const char CREATED[] = NS_DCTERMS "created";
      static const char VALID[] = NS_DCTERMS "valid";
      static const char AVAILABLE[] = NS_DCTERMS "available";
      static const char ISSUED[] = NS_DCTERMS "issued";
      static const char MODIFIED[] = NS_DCTERMS "modified";
      static const char EXTENT[] = NS_DCTERMS "extent";
      static const char MEDIUM[] = NS_DCTERMS "medium";
      static const char ISVERSIONOF[] = NS_DCTERMS "isVersionOf";
      static const char HASVERSION[] = NS_DCTERMS "hasVersion";
      static const char ISREPLACEDBY[] = NS_DCTERMS "isReplacedBy";
      static const char REPLACES[] = NS_DCTERMS "replaces";
      static const char ISREQUIREDBY[] = NS_DCTERMS "isRequiredBy";
      static const char REQUIRES[] = NS_DCTERMS "requires";
      static const char ISPARTOF[] = NS_DCTERMS "isPartOf";
      static const char HASPART[] = NS_DCTERMS "hasPart";
      static const char ISREFERENCEDBY[] = NS_DCTERMS "isReferencedBy";
      static const char REFERENCES[] = NS_DCTERMS "references";
      static const char ISFORMATOF[] = NS_DCTERMS "isFormatOf";
      static const char HASFORMAT[] = NS_DCTERMS "hasFormat";
      static const char CONFORMSTO[] = NS_DCTERMS "conformsTo";
      static const char SPATIAL[] = NS_DCTERMS "spatial";
      static const char TEMPORAL[] = NS_DCTERMS "temporal";
      static const char MEDIATOR[] = NS_DCTERMS "mediator";
      static const char DATEACCEPTED[] = NS_DCTERMS "dateAccepted";
      static const char DATECOPYRIGHTED[] = NS_DCTERMS "dateCopyrighted";
      static const char DATESUBMITTED[] = NS_DCTERMS "dateSubmitted";
      static const char EDUCATIONLEVEL[] = NS_DCTERMS "educationLevel";
      static const char ACCESSRIGHTS[] = NS_DCTERMS "accessRights";
      static const char BIBLIOGRAPHICCITATION[] = NS_DCTERMS "bibliographicCitation";
      static const char LICENSE[] = NS_DCTERMS "license";
      static const char RIGHTSHOLDER[] = NS_DCTERMS "rightsHolder";
      static const char PROVENANCE[] = NS_DCTERMS "provenance";
      static const char INSTRUCTIONALMETHOD[] = NS_DCTERMS "instructionalMethod";
      static const char ACCRUALMETHOD[] = NS_DCTERMS "accrualMethod";
      static const char ACCRUALPERIODICITY[] = NS_DCTERMS "accrualPeriodicity";
      static const char ACCRUALPOLICY[] = NS_DCTERMS "accrualPolicy";

      //usage: URI::DCTERMS::TITLE, URI::DCTERMS::SUBJECT etc.
      static const char TITLE[] = NS_DCTERMS "title";
      static const char CREATOR[] = NS_DCTERMS "creator";
      static const char SUBJECT[] = NS_DCTERMS "subject";
      static const char DESCRIPTION[] = NS_DCTERMS "description";
      static const char PUBLISHER[] = NS_DCTERMS "publisher";
      static const char CONTRIBUTOR[] = NS_DCTERMS "contributor";
      static const char DATE[] = NS_DCTERMS "date";
      static const char TYPE[] = NS_DCTERMS "type";
      static const char FORMAT[] = NS_DCTERMS "format";
      static const char IDENTIFIER[] = NS_DCTERMS "identifier";
      static const char SOURCE[] = NS_DCTERMS "source";
      static const char LANGUAGE[] = NS_DCTERMS "language";
      static const char RELATION[] = NS_DCTERMS "relation";
      static const char COVERAGE[] = NS_DCTERMS "coverage";
      static const char RIGHTS[] = NS_DCTERMS "rights";         
   }    
}

#endif
