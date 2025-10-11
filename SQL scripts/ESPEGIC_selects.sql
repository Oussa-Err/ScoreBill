SELECT 
    m.Name AS [Nom du marche], 
    COUNT(d.DivisionId) AS [Nombre de Division], 
    CASE 
        WHEN m.TotalMaterialRequired = 0 THEN 0
        ELSE CAST((SUM(d.TotalMaterialCount) * 100.0 / m.TotalMaterialRequired) AS DECIMAL(10, 2))
    END AS [Avancement d'inventaire]
FROM 
    Marche m
LEFT JOIN 
    Division d ON m.MarcheId = d.MarcheId
GROUP BY 
    m.Name, m.TotalMaterialRequired;

select * from Division

select * from Admin