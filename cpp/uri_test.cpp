#include <iostream>
#include "URI_CRM42.hpp"
#include "URI_CRMEH.hpp"
#include "URI_DC.hpp"
#include "URI_DCTERMS.hpp"
#include "URI_ECRM.hpp"
#include "URI_OWL.hpp"
#include "URI_RDF.hpp"
#include "URI_RDFS.hpp"
#include "URI_SKOS.hpp"
#include "URI_SKOSXL.hpp"

using namespace std;

int main()
{
	printf("URI::CRM42::E1='%s'\n", URI::CRM42::E1);
	printf("URI::CRM42::P2F='%s'\n", URI::CRM42::P2F);

	printf("URI::CRMEH::EHE0001='%s'\n", URI::CRMEH::EHE0001);
	printf("URI::CRMEH::EHP1F='%s'\n", URI::CRMEH::EHP1F);

	printf("URI::DC::SUBJECT='%s'\n", URI::DC::SUBJECT);
	printf("URI::DC::DESCRIPTION='%s'\n", URI::DC::DESCRIPTION);

	printf("URI::DCTERMS::SUBJECT='%s'\n", URI::DCTERMS::SUBJECT);
	printf("URI::DCTERMS::DESCRIPTION='%s'\n", URI::DCTERMS::DESCRIPTION);

	printf("URI::ECRM::E1='%s'\n", URI::ECRM::E1);
	printf("URI::ECRM::P1='%s'\n", URI::ECRM::P1);

	printf("URI::OWL::CLASS='%s'\n", URI::OWL::CLASS);
	printf("URI::OWL::CARDINALITY='%s'\n", URI::OWL::CARDINALITY);

	printf("URI::RDF::PROPERTY='%s'\n", URI::RDF::PROPERTY);
	printf("URI::RDF::SUBJECT='%s'\n", URI::RDF::SUBJECT);

	printf("URI::RDFS::RESOURCE='%s'\n", URI::RDFS::RESOURCE);
	printf("URI::RDFS::DOMAIN='%s'\n", URI::RDFS::DOMAIN);

	printf("URI::SKOS::PREFLABEL='%s'\n", URI::SKOS::PREFLABEL);
	printf("URI::SKOS::ALTLABEL='%s'\n", URI::SKOS::ALTLABEL);

	printf("URI::SKOSXL::PREFLABEL='%s'\n", URI::SKOSXL::PREFLABEL);
	printf("URI::SKOSXL::ALTLABEL='%s'\n", URI::SKOSXL::ALTLABEL);

   std::string expected = "http://purl.org/dc/terms/subject";
   std::string actual = URI::DCTERMS::SUBJECT;
   if(actual == expected)
        printf("\n%s : strings matched\n", actual.c_str()); 
   else
       printf("\n%s : strings did not match\n", actual.c_str()); 
   system("PAUSE");
   return(0);
}
