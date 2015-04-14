#!/usr/bin/env python
#############################
# Module:   URI_SKOS.py
# Author:   C Binding
# Date:     2008-07-09
# Version:  Draft 0.1
'''
Module defines URI constants for SKOS RDF entities and properties
'''
###############################
# Log:
# 2008-07-09    CFB - Initially created module
################################

NS_SKOS = "http://www.w3.org/2004/02/skos/core#"    
#Entity types
COLLECTABLEPROPERTY = NS_SKOS + "CollectableProperty"
COLLECTION = NS_SKOS + "Collection"
CONCEPT = NS_SKOS + "Concept"
CONCEPTSCHEME = NS_SKOS + "ConceptScheme"
ORDEREDCOLLECTION = NS_SKOS + "OrderedCollection"
#Property types
ALTLABEL = NS_SKOS + "altLabel"
ALTSYMBOL = NS_SKOS + "altSymbol"
BROADER = NS_SKOS + "broader"
CHANGENOTE = NS_SKOS + "changeNote"
DEFINITION = NS_SKOS + "definition"
EDITORIALNOTE = NS_SKOS + "editorialNote"
EXAMPLE = NS_SKOS + "example"
HASTOPCONCEPT = NS_SKOS + "hasTopConcept"
HIDDENLABEL = NS_SKOS + "hiddenLabel"
HISTORYNOTE = NS_SKOS + "historyNote"
INSCHEME = NS_SKOS + "inScheme"
ISPRIMARYSUBJECTOF = NS_SKOS + "isPrimarySubjectOf"
ISSUBJECTOF = NS_SKOS + "isSubjectOf"
MEMBER = NS_SKOS + "member"
MEMBERLIST = NS_SKOS + "memberList"
NARROWER = NS_SKOS + "narrower"
NOTE = NS_SKOS + "note"
PREFLABEL = NS_SKOS + "prefLabel"
PREFSYMBOL = NS_SKOS + "prefSymbol"
PRIMARYSUBJECT = NS_SKOS + "primarySubject"
RELATED = NS_SKOS + "related"
SCOPENOTE = NS_SKOS + "scopeNote"
SEMANTICRELATION = NS_SKOS + "semanticRelation"
SUBJECT = NS_SKOS + "subject"
SUBJECTINDICATOR = NS_SKOS + "subjectIndicator"
SYMBOL = NS_SKOS + "symbol"