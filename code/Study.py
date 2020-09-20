def p(var):
    print(var)
    return

a=1
b=1.5
c=1234567890123456
d="444"
e='c'
p('Hello, world!')
p(c)

for i in range(1,10):
	p(i)

j=1
while j<10:
	p(j)
	j+=1
	
if 1==2:
	p(666)
else:
	p(777)