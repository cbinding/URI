"""
===============================================================================
Creator : Ceri Binding, University of South Wales | Prifysgol de Cymru 
Contact : ceri.binding@southwales.ac.uk
Project : Any
Classes : URI_RDFS
Summary : Case-sensitive entity & property URI constants (for RDF apps) 
Example : 
    import URI_RDFS
    print(URI_RDFS.CLASS) # "http://www.w3.org/2000/01/rdf-schema#Class"
License : https://mit-license.org
History :
23/02/2023 CFB Extracted from old script, updated to use F-strings
===============================================================================
"""
# Namespace
NS = "http://www.w3.org/2000/01/rdf-schema#"

# Entities
RESOURCE = f"{NS}Resource"
LITERAL = f"{NS}Literal"
CLASS = f"{NS}Class"
DATATYPE = f"{NS}Datatype"
CONTAINER = f"{NS}Container"
CONTAINERMEMBERSHIPPROPERTY = f"{NS}ContainerMembershipProperty"

# Properties
SUBCLASSOF = f"{NS}subClassOf"
SUBPROPERTYOF = f"{NS}subPropertyOf"
DOMAIN = f"{NS}domain"
RANGE = f"{NS}range"
LABEL = f"{NS}label"
COMMENT = f"{NS}comment"
MEMBER = f"{NS}member"
SEEALSO = f"{NS}seeAlso"
ISDEFINEDBY = f"{NS}isDefinedBy"
