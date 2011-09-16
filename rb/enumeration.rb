# =============================================================================
# Project	: URI
# Modules	: Enumeration
# Summary	: Enumeration class	  
# -----------------------------------------------------------------------------
# History
# -----------------------------------------------------------------------------
# Ref	Who	DateDetails
# ---	---	-----------
# 001	CFB	24/04/2009	Initially created module
# =============================================================================
class Enumeration
	def Enumeration.add(key,value)
        @hash ||= {}
        @hash[key]=value
    end
    
    def Enumeration.const_missing(key)
        @hash[key]
    end    
    
    def Enumeration.each
        @hash.each {|key,value| yield(key,value)}
    end
end


# testing code 
if __FILE__ == $0 
	#example enumerations defined
	class EnumColor < Enumeration    
		EnumColor.add :BLUE, 1
		EnumColor.add :RED, 2
		EnumColor.add :YELLOW, 3
		EnumColor.add :GREEN, 4
	end

	class EnumDay < Enumeration
		EnumDay.add :SUN, "Sunday"
		EnumDay.add :MON, "Monday"
		EnumDay.add :TUE, "Tuesday"
		EnumDay.add :WED, "Wednesday"
		EnumDay.add :THU, "Thursday"
		EnumDay.add :FRI, "Friday"
		EnumDay.add :SAT, "Saturday"
	end

	class EnumMonth < Enumeration
		EnumMonth.add :JAN, "January"
		EnumMonth.add :FEB, "February"
		EnumMonth.add :MAR, "March"
		EnumMonth.add :APR, "April"
		EnumMonth.add :MAY, "May"
		EnumMonth.add :JUN, "June"
		EnumMonth.add :JUL, "July"
		EnumMonth.add :AUG, "August"
		EnumMonth.add :SEP, "September"
		EnumMonth.add :OCT, "October"
		EnumMonth.add :NOV, "November"
		EnumMonth.add :DEC, "December"
	end

	
	#test the enumerations
	puts EnumDay::WED
	puts EnumMonth::AUG	
	EnumColor.each do |key,value|
		puts "#{key} #{value}"  
	end
end
