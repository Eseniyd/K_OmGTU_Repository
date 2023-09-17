# №1
P, K, L, N = map(int, input().split())
ans = 0
for i in range(1, N+1):
    ans+= 2*P + L*(i+1) + L*(i-1) + 2*K
print(ans)
# №2
p, k, l, n = map(int, input().split())
print(2*n*(p+k+l)+l*n*(n-1))
