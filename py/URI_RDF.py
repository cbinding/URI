#!/usr/bin/env python
#############################
# Module:   URI_RDF.py
# Author:   C Binding
# Date:     2008-07-09
# Version:  Draft 0.1
'''
Module defines URI constants for RDF entities and properties
'''
###############################
# Log:
# 2008-07-09    CFB - Initially created module
################################

NS_RDF = "http://www.w3.org/1999/02/22-rdf-syntax-ns#"    
#Entity types
XMLLITERAL = NS_RDF + "XMLLiteral"
PROPERTY = NS_RDF + "Property"
STATEMENT = NS_RDF + "Statement"
BAG = NS_RDF + "Bag"
SEQ = NS_RDF + "Seq"
ALT = NS_RDF + "Alt"
LIST = NS_RDF + "List"
#Property types
TYPE = NS_RDF + "type"
FIRST = NS_RDF + "first"
REST = NS_RDF + "rest"
VALUE = NS_RDF + "value"
SUBJECT = NS_RDF + "subject"
PREDICATE = NS_RDF + "predicate"
OBJECT = NS_RDF + "object"
ID = NS_RDF + "ID"