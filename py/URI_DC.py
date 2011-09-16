#!/usr/bin/env python
#############################
# Module:   URI_DC.py
# Author:   C Binding
# Date:     2008-07-09
# Version:  Draft 0.1
'''
Module defines URI constants for DC RDF entities and properties
'''
###############################
# Log:
# 2008-07-09    CFB - Initially created module
################################

NS_DC = "http://purl.org/dc/elements/1.1/"    
#Property types
TITLE = NS_DC +  "title"
CREATOR = NS_DC +  "creator"
SUBJECT = NS_DC +  "subject"
DESCRIPTION = NS_DC +  "description"
PUBLISHER = NS_DC +  "publisher"
CONTRIBUTOR = NS_DC +  "contributor"
DATE = NS_DC +  "date"
TYPE = NS_DC +  "type"
FORMAT = NS_DC +  "format"
IDENTIFIER = NS_DC +  "identifier"
SOURCE = NS_DC +  "source"
LANGUAGE = NS_DC +  "language"
RELATION = NS_DC +  "relation"
COVERAGE = NS_DC +  "coverage"
RIGHTS = NS_DC +  "rights"