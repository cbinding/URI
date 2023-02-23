"""
===============================================================================
Creator : Ceri Binding, University of South Wales | Prifysgol de Cymru 
Contact : ceri.binding@southwales.ac.uk
Project : Any
Classes : URI_SKOS
Summary : Case-sensitive entity & property URI constants (for RDF apps)
          NOTE: constants by convention only, not immutable in Python
Example : 
    import URI_SKOS
    print(URI_SKOS.CONCEPT) # "http://www.w3.org/2004/02/skos/core#Concept"
License : https://mit-license.org
History :
23/02/2023 CFB Extracted from old script, updated to use F-strings
===============================================================================
"""
from types import MappingProxyType

# Namespace
NS = "http://www.w3.org/2004/02/skos/core#"

# Entities
COLLECTABLEPROPERTY = f"{NS}CollectableProperty"
COLLECTION = f"{NS}Collection"
CONCEPT = f"{NS}Concept"
CONCEPTSCHEME = f"{NS}ConceptScheme"
ORDEREDCOLLECTION = f"{NS}OrderedCollection"

# Properties
ALTLABEL = f"{NS}altLabel"
ALTSYMBOL = f"{NS}altSymbol"
BROADER = f"{NS}broader"
CHANGENOTE = f"{NS}changeNote"
DEFINITION = f"{NS}definition"
EDITORIALNOTE = f"{NS}editorialNote"
EXAMPLE = f"{NS}example"
HASTOPCONCEPT = f"{NS}hasTopConcept"
HIDDENLABEL = f"{NS}hiddenLabel"
HISTORYNOTE = f"{NS}historyNote"
INSCHEME = f"{NS}inScheme"
ISPRIMARYSUBJECTOF = f"{NS}isPrimarySubjectOf"
ISSUBJECTOF = f"{NS}isSubjectOf"
MEMBER = f"{NS}member"
MEMBERLIST = f"{NS}memberList"
NARROWER = f"{NS}narrower"
NOTE = f"{NS}note"
PREFLABEL = f"{NS}prefLabel"
PREFSYMBOL = f"{NS}prefSymbol"
PRIMARYSUBJECT = f"{NS}primarySubject"
RELATED = f"{NS}related"
SCOPENOTE = f"{NS}scopeNote"
SEMANTICRELATION = f"{NS}semanticRelation"
SUBJECT = f"{NS}subject"
SUBJECTINDICATOR = f"{NS}subjectIndicator"
SYMBOL = f"{NS}symbol"
