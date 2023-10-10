import React, { useState, useEffect } from 'react';

const HighscoreList = () => {
    const [highscores, setHighscores] = useState([]);

    useEffect(() => {
        const fetchData = async () => {
            try {
                const response = await fetch('/api/highscore');
                const data = await response.json();
                setHighscores(data);
            } catch (error) {
                console.error('Error fetching highscores:', error);
            }
        }

        fetchData();
    }, []);

    return (
        <div>
            <h1>Highscores</h1>
            <ul>
                {highscores.map((score, index) => (
                    <li key={index}>{score.name}: {score.score}</li>
                ))}
            </ul>
        </div>
    );
};

export default HighscoreList;