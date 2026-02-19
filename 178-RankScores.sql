SELECT score AS score, i AS rank  
FROM( SELECT score, 
      DENSE_RANK() OVER (ORDER BY score DESC) 
      as i FROM Scores 
    ) t
