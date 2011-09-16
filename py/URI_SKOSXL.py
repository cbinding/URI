#!/usr/bin/env python
#############################
# Module:   URI_SKOSXL.py
# Author:   C Binding
# Date:     2008-07-09
# Version:  Draft 0.1
'''
Module defines URI constants for SKOSXL RDF entities and properties
'''
###############################
# Log:
# 2008-07-09    CFB - Initially created module
################################

NS_SKOSXL = "http://www.w3.org/2008/05/skos-xl#"    
#Entities
LABEL = NS_SKOSXL + "Label"
#Properties
PREFLABEL = NS_SKOSXL + "prefLabel"
ALTLABEL = NS_SKOSXL + "altLabel"
HIDDENLABEL = NS_SKOSXL + "hiddenLabel"
LABELRELATION = NS_SKOSXL + "labelRelation"
LITERALFORM = NS_SKOSXL + "literalForm"
