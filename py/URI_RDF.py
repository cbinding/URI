"""
===============================================================================
Creator : Ceri Binding, University of South Wales | Prifysgol de Cymru 
Contact : ceri.binding@southwales.ac.uk
Project : Any
Classes : URI_RDF
Summary : Case-sensitive entity & property URI constants (for RDF apps) 
Example : 
    import URI_RDF
    print(URI_RDF.TYPE) # " http://www.w3.org/1999/02/22-rdf-syntax-ns#type"
License : https://mit-license.org
History :
23/02/2023 CFB Extracted from old script, updated to use F-strings
===============================================================================
"""
# Namespace
NS = "http://www.w3.org/1999/02/22-rdf-syntax-ns#"

# Entities
XMLLITERAL = f"{NS}XMLLiteral"
PROPERTY = f"{NS}Property"
STATEMENT = f"{NS}Statement"
BAG = f"{NS}Bag"
SEQ = f"{NS}Seq"
ALT = f"{NS}Alt"
LIST = f"{NS}List"

# Properties
TYPE = f"{NS}type"
FIRST = f"{NS}first"
REST = f"{NS}rest"
VALUE = f"{NS}value"
SUBJECT = f"{NS}subject"
PREDICATE = f"{NS}predicate"
OBJECT = f"{NS}object"
ID = f"{NS}ID"
