"""
===============================================================================
Creator : Ceri Binding, University of South Wales | Prifysgol de Cymru 
Contact : ceri.binding@southwales.ac.uk
Project : Any
Classes : URI_SKOSXL
Summary : Case-sensitive entity & property URI constants (for RDF apps) 
Example : 
    import URI_SKOSXL
    print(URI_SKOSXL.PREFLABEL) # "http://www.w3.org/2008/05/skos-xl#prefLabel"
License : https://mit-license.org
History :
23/02/2023 CFB Extracted from old script, updated to use F-strings
===============================================================================
"""
# Namespace
NS = "http://www.w3.org/2008/05/skos-xl#"

# Entities
LABEL = f"{NS}Label"

# Properties
PREFLABEL = f"{NS}prefLabel"
ALTLABEL = f"{NS}altLabel"
HIDDENLABEL = f"{NS}hiddenLabel"
LABELRELATION = f"{NS}labelRelation"
LITERALFORM = f"{NS}literalForm"
