#!/usr/bin/env python
#############################
# Module:   URI_RDFS.py
# Author:   C Binding
# Date:     2008-07-09
# Version:  Draft 0.1
'''
Module defines URI constants for RDFS entities and properties
'''
###############################
# Log:
# 2008-07-09    CFB - Initially created module
################################

NS_RDFS = "http://www.w3.org/2000/01/rdf-schema#"    
#Entity types
RESOURCE = NS_RDFS + "Resource"
LITERAL = NS_RDFS + "Literal"
CLASS = NS_RDFS + "Class"
DATATYPE = NS_RDFS + "Datatype"
CONTAINER = NS_RDFS + "Container"
CONTAINERMEMBERSHIPPROPERTY = NS_RDFS + "ContainerMembershipProperty"
#Property types
SUBCLASSOF = NS_RDFS + "subClassOf"
SUBPROPERTYOF = NS_RDFS + "subPropertyOf"
DOMAIN = NS_RDFS + "domain"
RANGE = NS_RDFS + "range"
LABEL = NS_RDFS + "label"
COMMENT = NS_RDFS + "comment"
MEMBER = NS_RDFS + "member"
SEEALSO = NS_RDFS + "seeAlso"
ISDEFINEDBY = NS_RDFS + "isDefinedBy"