#ifndef _URI_DC_H 
#define _URI_DC_H 

#define NS_DC "http://purl.org/dc/elements/1.1/"    
      
namespace URI
{
   namespace DC
   {  
    //usage: URI::DC::TITLE, URI::DC::SUBJECT etc.
    static const char TITLE[] = NS_DC "title";
    static const char CREATOR[] = NS_DC "creator";
    static const char SUBJECT[] = NS_DC "subject";
    static const char DESCRIPTION[] = NS_DC "description";
    static const char PUBLISHER[] = NS_DC "publisher";
    static const char CONTRIBUTOR[] = NS_DC "contributor";
    static const char DATE[] = NS_DC "date";
    static const char TYPE[] = NS_DC "type";
    static const char FORMAT[] = NS_DC "format";
    static const char IDENTIFIER[] = NS_DC "identifier";
    static const char SOURCE[] = NS_DC "source";
    static const char LANGUAGE[] = NS_DC "language";
    static const char RELATION[] = NS_DC "relation";
    static const char COVERAGE[] = NS_DC "coverage";
    static const char RIGHTS[] = NS_DC "rights";         
   }    
}

#endif
