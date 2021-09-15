# @param {Integer} num
# @return {String}
def int_to_roman(num)
    ones = Array.[]('I', 'X', 'C', 'M')
    fives = Array.[]('V', 'L', 'D')
    stk = Array.new
    digit = -1
    while num > 0
        stk.push(num%10)
        num/=10
        digit+=1
    end
    lat = ""
    while stk.size > 0 
        d = stk.pop
        if d == 4 
           lat += ones[digit]
           lat += fives[digit]
        elsif d == 9 
           lat += ones[digit]
           lat += ones[digit+1]
        elsif d >= 1
            base = d >= 5 ? 5 : 1
            lat += base == 1?ones[digit]:fives[digit]
            for i in 1..d-base
                lat += ones[digit]
            end
        end
        digit-=1
    end
    return lat 
end
