require "enumeration"

#simple
class Color
  BLUE=1
  RED=2
  GREEN=3
  YELLOW=4
  ORANGE=5
  PURPLE=6
end
#usage e.g.
#paint_the_car(Color::YELLOW)


class EnumColor < Enumeration    
    EnumColor.add :BLUE, 1
    EnumColor.add :RED, 2
    EnumColor.add :YELLOW, 3
	EnumColor.add :GREEN, 4
end

class EnumScale < Enumeration
	EnumScale.add :M, 1 #1,3,5
	EnumScale.add :m, 1 #1,b3,5
	EnumScale.add :M7, 1 #1,3,5,7
	EnumScale.add :m7, 1 #1, b3, 5, b7
	EnumScale.add :"7", 1 #1, 3, 5, b7
end

class EnumNote < Enumeration
	EnumNote.add :C, 1
	EnumNote.add :"C\#", 2	
	EnumNote.add :Db, 2
	EnumNote.add :D, 3
	EnumNote.add :"D\#", 4
	EnumNote.add :Eb, 4
	EnumNote.add :E, 5
	EnumNote.add :F, 6
	EnumNote.add :"F\#", 7
	EnumNote.add :Gb, 7
	EnumNote.add :G, 8
	EnumNote.add :"G#", 9
	EnumNote.add :Ab, 9
	EnumNote.add :A, 10
	EnumNote.add :"A#", 11
	EnumNote.add :Bb, 11
	EnumNote.add :B, 12
end

#usage:
#puts RDF_199902::NS
#puts RDF_199902::STATEMENT
#can also use for..each
class RDF_199902 < Enumeration 
		NS = "http://www.w3.org/1999/02/22-rdf-syntax-ns#"
		RDF_199902.add :XMLLITERAL,NS + "XMLLiteral"
		RDF_199902.add :PROPERTY, NS + "Property"
		RDF_199902.add :STATEMENT, NS + "Statement"
		RDF_199902.add :BAG, NS + "Bag"
	end
 
#That’s it! We can now use our enum :
#my_color = Color::RED etc. 
#And we can loop. Note these will not necessarily be in order!
EnumColor.each do |key,value|
	#do_something_with_value(value)
	puts "#{key} #{value}"  
end

RDF_199902.each do |key,value|
	#do_something_with_value(value)
	puts "#{key} #{value}"  
end