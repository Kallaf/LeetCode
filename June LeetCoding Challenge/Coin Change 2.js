var memo;

function ways(type,value,coins)
{
    if(value === 0)return 1;
    if(value < 0)return 0;
    if(type === coins.length)return 0;
    if(memo[type][value] !== -1)return memo[type][value];
    return memo[type][value] = ways(type + 1, value,coins) + // if we ignore this coin type,
    ways(type, value - coins[type],coins); // plus if we use this coin type
}

var change = function(amount, coins) {
    memo = Array.from({ length:coins.length+1 }, () => (
      Array.from({ length:amount+3 }, ()=> -1)
    ));
    return ways(0,amount,coins);
};
